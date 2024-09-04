using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACS.SPiiPlusNET;      // ACS .NET Library
using System.Threading;
using WhyfdrCamera;

namespace DrlaserCutSystem.Handle
{
    class ACSHandle
    {
        // 单例模式

        bool m_AcsInitFlag;
        public int m_nTotalAxis, m_nTotalBuffer = 0;
        private ACS.SPiiPlusNET.Axis[] m_arrAxisList = null;
        MotorStates m_XMotorState, m_YMotorState, m_RMotorState;

        private ProgramStates m_nProgramState0, m_nProgramState1, m_nProgramState2, m_nProgramState3, m_nProgramState4;

        private Api _ACS;
        public ACSHandle() 
        { 
            _ACS=new  Api();
        }
        public static ACSHandle instance;
        public static ACSHandle getInstance()
        {
            if (instance == null)
            {
                instance = new ACSHandle();

            }
            return instance;
        }
        /// <summary>
        /// 获取初始化状态
        /// </summary>
        /// <returns></returns>
        public bool fGetAcsConnnectStu() 
        {
            return m_AcsInitFlag;
        }
        /// <summary>
        /// ACS初始化
        /// </summary>
        public bool  init() 
        {
            string strTemp;
            int i;
            try
            {
                _ACS.OpenCommEthernetTCP("10.0.0.100", 701);
                //tmrACS.Start();

                strTemp = _ACS.Transaction("?SYSINFO(13)");
                m_nTotalAxis = Convert.ToInt32(strTemp.Trim());
                m_arrAxisList = new ACS.SPiiPlusNET.Axis[m_nTotalAxis + 1];
                for (i = 0; i < m_nTotalAxis; i++)
                {
                    m_arrAxisList[i] = (ACS.SPiiPlusNET.Axis)i;
                }
                // Insert '-1' at the last
                m_arrAxisList[m_nTotalAxis] = ACS.SPiiPlusNET.Axis.ACSC_NONE;

                strTemp = _ACS.Transaction("?SYSINFO(10)");
                m_nTotalBuffer = Convert.ToInt32(strTemp.Trim());


                _ACS.Enable(ACS.SPiiPlusNET.Axis.ACSC_AXIS_0);
                _ACS.Enable(ACS.SPiiPlusNET.Axis.ACSC_AXIS_1);
                //ACSConnect.Enabled = false;
                //ACSDisConnect.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //tmrACS.Stop();
                return  m_AcsInitFlag = false;
            }
            return m_AcsInitFlag = true;
        }
        /// <summary>
        /// 断开连接
        /// </summary>
        public void fAcsDisconnect() 
        {
            _ACS.CloseComm();
            m_AcsInitFlag = false;
        }
        /// <summary>
        /// 系统复位
        /// </summary>
        /// <returns></returns>
        public bool fSystemHome() 
        {
            m_XMotorState = _ACS.GetMotorState(ACS.SPiiPlusNET.Axis.ACSC_AXIS_0);
            m_YMotorState = _ACS.GetMotorState(ACS.SPiiPlusNET.Axis.ACSC_AXIS_1);
            m_RMotorState = _ACS.GetMotorState(ACS.SPiiPlusNET.Axis.ACSC_AXIS_2);
            if (((m_XMotorState & MotorStates.ACSC_MST_INPOS) != 0) && ((m_YMotorState & MotorStates.ACSC_MST_INPOS) != 0) && ((m_RMotorState & MotorStates.ACSC_MST_INPOS) != 0))//电机停止
            {
                try
                {
                    _ACS.RunBuffer((ProgramBuffer)1, null);
                    _ACS.RunBuffer((ProgramBuffer)2, null);
                    _ACS.RunBuffer((ProgramBuffer)3, null);
                    Thread.Sleep(100);

                    m_nProgramState1 = _ACS.GetProgramState((ProgramBuffer)1);
                    m_nProgramState2 = _ACS.GetProgramState((ProgramBuffer)2);
                    m_nProgramState3 = _ACS.GetProgramState((ProgramBuffer)3);

                    //// 等待返回
                    var checkResult = GlobalMethod.TimeOutCheck(60000, () =>
                    {
                        while (((m_nProgramState1 & ProgramStates.ACSC_PST_RUN) != 0) || ((m_nProgramState2 & ProgramStates.ACSC_PST_RUN) != 0) || ((m_nProgramState3 & ProgramStates.ACSC_PST_RUN) != 0))
                        {
                            m_nProgramState1 = _ACS.GetProgramState((ProgramBuffer)1);
                            m_nProgramState2 = _ACS.GetProgramState((ProgramBuffer)2);
                            m_nProgramState3 = _ACS.GetProgramState((ProgramBuffer)3);
                            System.Threading.Thread.Sleep(1);
                        }
                        return true;
                    });
                    //if (!checkResult)
                    //{
                    //    //ErrorDispose.getInstance().AddErrLog((int)LaserErrCode.LES_RCVTIMEOUT);
                    //    return false; 
                    //}
                    return checkResult;                
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            } 
        }  
        /// <summary>
        /// 运行buffer
        /// </summary>
        /// <param name="BufferNo"></param>
        public void  fRunBuffer(int BufferNo) 
        {
            _ACS.RunBuffer((ProgramBuffer)BufferNo, null);
            //return true;
        }
        /// <summary>
        /// 往ACS控制器写变量
        /// </summary>
        public void fWriteVartoAcs(object value,string varname,int bufferno) 
        {
            try
            {
                _ACS.WriteVariable(value, varname, (ProgramBuffer)bufferno);
            }
            catch 
            {
                m_AcsInitFlag = false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void fStop() 
        {
            if (m_arrAxisList != null) _ACS.HaltM(m_arrAxisList);
        }
        /// <summary>
        /// 获取电机实时位置
        /// </summary>
        /// <param name="AxisNo"></param>
        /// <returns></returns>
        public double fGetAxisPos(ACS.SPiiPlusNET.Axis AxisNo) 
        {
            try
            {
                double ret;
                ret = _ACS.GetFPosition(AxisNo);
                return ret;
            }
            catch 
            {
                m_AcsInitFlag = false;
                return 0;
            }
        }
        /// <summary>
        /// 运动
        /// </summary>
        /// <param name="MotionStyle"></param>
        /// <param name="AxisNo"></param>
        /// <param name="Postion"></param>
        /// <param name="Velocity"></param>
        public void fToPoint(MotionFlags MotionStyle,ACS.SPiiPlusNET.Axis AxisNo,double Postion,double Velocity ) 
        {
            m_XMotorState = _ACS.GetMotorState(AxisNo);
            if ((m_XMotorState & MotorStates.ACSC_MST_INPOS) != 0)//电机停止
            {
                    _ACS.SetVelocity(AxisNo, Velocity);
                    _ACS.ToPoint(MotionStyle, AxisNo, Postion);
            }
        }
        /// <summary>
        /// 差补运动
        /// </summary>
        /// <param name="MotionStyle"></param>
        /// <param name="axes"></param>
        /// <param name="point"></param>
        public void fToPointM(MotionFlags MotionStyle,Axis[] axes, double[] point) 
        {
            m_XMotorState = _ACS.GetMotorState(axes[0]);
            m_YMotorState = _ACS.GetMotorState(axes[1]);
            if ((m_XMotorState & m_YMotorState & MotorStates.ACSC_MST_INPOS) != 0)//电机停止
            {
                //_ACS.SetVelocity(AxisNo, Velocity);
                _ACS.ExtToPointM(MotionStyle, axes, point,100,100);
            }
        }
        /// <summary>
        /// 往BUDDER添加语句
        /// </summary>
        /// <param name="bufferno"></param>
        /// <param name="buffertext"></param>
        public void fappendbuffer(int bufferno,string buffertext) 
        {
            try
            {
                _ACS.AppendBuffer((ProgramBuffer)bufferno, buffertext);
            }
            catch 
            {
                m_AcsInitFlag = false;
            }
        }
        /// <summary>
        /// 清空BUUFER
        /// </summary>
        /// <param name="bufferno"></param>
        public void fclearbuffer(int bufferno) 
        {
            try
            {
                _ACS.ClearBuffer((ProgramBuffer)bufferno, 1, 100000);
            }
            catch 
            {
                m_AcsInitFlag = false;
            }
        }
        /// <summary>
        /// 获取轴当前状态
        /// </summary>
        /// <param name="AxisNo"></param>
        /// <returns></returns>
        public MotorStates fgetaxisstatus(ACS.SPiiPlusNET.Axis AxisNo) 
        {
            try
            {
                return _ACS.GetMotorState(AxisNo);
            }
            catch 
            {
                m_AcsInitFlag = false;
                return MotorStates.ACSC_NONE;
            }
        }
        /// <summary>
        /// 判断轴是否在运动
        /// </summary>
        /// <returns></returns>
        public bool fiSmoving(ACS.SPiiPlusNET.Axis axisno)
        {
            m_XMotorState = _ACS.GetMotorState(axisno);
            if ((m_XMotorState & MotorStates.ACSC_MST_INPOS) != 0)
            {
                return true;
            }
            return false;
        }
    }
}
