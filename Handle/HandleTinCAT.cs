using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinCAT.Ads;
using System.IO;
using System.Windows.Forms;
namespace WhyfdrCamera
{
    class HandleTinCAT
    {
        //变量定义
        public static TcAdsClient tcClient = new TcAdsClient();
        public bool m_bInitSuc;
        private int FormHMIReadhvarSys, FormHMIReadhvarSys1;//建立中断事件句柄
        AdsStream Sysdatastream,Sysdatastream1;
        AdsBinaryReader SysbinRead, SysbinRead1;
        private int FormHMIWritehvar, FormHMIReadhvar1, FormHMIReadhvar2, FormHMIReadhvar3;//建立句柄
        int FormHMIReadbvarTemp;//临时共用句柄
        public int[] AlarmArray = new int[100];
        int m_count2;
        public static HandleTinCAT instance;
        public static HandleTinCAT getInstance()
        {
            if (instance == null)
            {
                instance = new HandleTinCAT();
            }
            return instance;
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        public bool Init()
        {

            //tcClient.Connect("172.255.255.255.1.1", 801);
            tcClient.Connect("172.255.255.255.1.1", 801);
            tcClient.Timeout = 5000;

            try
            {
                tcClient.WriteControl(new StateInfo(AdsState.Run, tcClient.ReadState().DeviceState));
            }
            catch
            {
                //MessageBox.Show("重新启动PLC失败，或者PLC已经在运行模式下!");
            }

            try
            {
                //传感器
                FormHMIReadhvar1 = tcClient.CreateVariableHandle(".stInput");
                //打标台面位置
                // FormHMIReadhvar2 = tcClient.CreateVariableHandle(".g_iTableNum_Load");
                //报警获取
                FormHMIReadhvar3 = tcClient.CreateVariableHandle(".Alarm");

                //打标1交互
                //FormHMIWritehvar = tcClient.CreateVariableHandle(".iState_CamWork_HMI");
                //Sysdatastream = new AdsStream(2); //每个元素占用2位
                //SysbinRead = new AdsBinaryReader(Sysdatastream);
                //FormHMIReadhvarSys = tcClient.AddDeviceNotification(".iState_CamWork_HMI", Sysdatastream, AdsTransMode.OnChange, 10, 0, 1);

                //打标1交互
                //FormHMIWritehvar1 = tcClient.CreateVariableHandle(".PieceStatus[15]");
                //Sysdatastream1 = new AdsStream(1); //每个元素占用2位
                //SysbinRead1 = new AdsBinaryReader(Sysdatastream1);
                //FormHMIReadhvarSys1 = tcClient.AddDeviceNotification(".PieceStatus[15]", Sysdatastream1, AdsTransMode.OnChange, 10, 0, 1);
            
                //创建全局句柄
                tcClient.AdsNotification += new AdsNotificationEventHandler(fhandel);
            }
            catch
            {
                return m_bInitSuc = false;
            }
            return m_bInitSuc = true;      
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool fGetSafeDoorStatus() 
        {
            return GlobalDefine.getInstance().stInpu[44] &&
                GlobalDefine.getInstance().stInpu[45] && GlobalDefine.getInstance().stInpu[46]
                && GlobalDefine.getInstance().stInpu[47] && GlobalDefine.getInstance().stInpu[48]
                && GlobalDefine.getInstance().stInpu[49] && GlobalDefine.getInstance().stInpu[50];
        }
        /// <summary>
        /// 获取初始化状态
        /// </summary>
        /// <returns></returns>
        public bool fGetInitStatus() 
        {
            return m_bInitSuc;        
        }
        /// <summary>
        /// ADS通信事件中断
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fhandel(object sender, AdsNotificationEventArgs e)
        {
            //拍照打标
            if (e.NotificationHandle == FormHMIReadhvarSys)
            {
                ;
            }
        }
        /// <summary>
        /// 删除句柄
        /// </summary>
        /// <returns></returns>
        public bool DeleteTwinCATHanle()
        {
            try
            {
                tcClient.DeleteVariableHandle(FormHMIReadbvarTemp);
                tcClient.DeleteVariableHandle(FormHMIReadhvarSys);
                tcClient.DeleteVariableHandle(FormHMIWritehvar);               
                return true;
            }
            catch(Exception e) 
            {
                ///ErrorDispose.getInstance().AddErrLog(1);
                return false;
            }                       
        }
        /// <summary>
        /// 获取PLC状态
        /// </summary>
        /// <returns></returns>
        public bool GetadsState()
        {
            try
            {
                if (tcClient.ReadState().AdsState != AdsState.Run)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 读BOOL变量
        /// </summary>
        /// <returns></returns>
        public bool fReadFromPlc_Bool(string Plc_Variable)
        {
            bool reVarValue = false;
            try
            {
                FormHMIReadbvarTemp = tcClient.CreateVariableHandle(Plc_Variable);
                reVarValue = Convert.ToBoolean(tcClient.ReadAny(FormHMIReadbvarTemp, typeof(System.Boolean)));
                return reVarValue;
            }
            catch(Exception e)
            {
                MessageBox.Show(Plc_Variable+"   "+e.Message);
                return false;
            }
        }
        /// <summary>
        /// 读INT
        /// </summary>
        /// <param name="Plc_Variable"></param>
        /// <returns></returns>
        public int fReaderFromPlc_int(string Plc_Variable)
        {
            int reVarValue = 0;
            try
            {
                FormHMIReadbvarTemp = tcClient.CreateVariableHandle(Plc_Variable);
                reVarValue = Convert.ToInt16(tcClient.ReadAny(FormHMIReadbvarTemp, typeof(Int16)));
                return reVarValue;
            }
            catch(Exception e)
            {
                MessageBox.Show(Plc_Variable + "   " + e.Message);
                return 0;
            }
        }
        /// <summary>
        /// 读string
        /// </summary>
        /// <param name="Plc_Variable"></param>
        /// <returns></returns>
        public string fReadFromPlc(string Plc_Variable)
        {
            string reVarValue;
            try
            {
                FormHMIReadbvarTemp = tcClient.CreateVariableHandle(Plc_Variable);
                reVarValue = tcClient.ReadAny(FormHMIReadbvarTemp, typeof(String), new int[] { 20 }).ToString();
                return reVarValue;
            }
            catch (Exception e)
            {
                //MessageBox.Show(Plc_Variable + "   " + e.Message);
                return "";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Plc_Variable"></param>
        /// <param name="OnOff"></param>
        public bool  fWriteToPlc(string Plc_Variable, bool OnOff)
        {
            if (!HandleTinCAT.getInstance().GetadsState())
                return false;
            try
            {
                tcClient.WriteSymbol(Plc_Variable, OnOff, false);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(Plc_Variable + "   " + e.Message);
                return false;
            }
        }
        /// <summary>
        /// 写INT
        /// </summary>
        /// <param name="Plc_Variable"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool fWriteToPlc_int(string Plc_Variable, Int16 value)
        {
            if (!HandleTinCAT.getInstance().GetadsState())
                return false;
            try
            {
                tcClient.WriteSymbol(Plc_Variable, value, false);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(Plc_Variable + "   " + e.Message);
                return false;
            }
        }
        /// <summary>
        /// 读取PLC报警
        /// </summary>
        public void fGetAlarmPlC() 
        {
            AdsStream datastream = new AdsStream(151);
            BinaryReader binread = new BinaryReader(datastream);
            datastream.Position = 0;
            int i;
            int AlarmCount = 0;

            try
            {
                tcClient.Read(FormHMIReadhvar3, datastream);

                for (i = 0; i < 151; i++)
                {
                    if (binread.ReadBoolean())
                    {
                        if (i == 11) //系统复位超时
                        {
                            GlobalDefine.getInstance().g_SysResetErr = true;
                        }
                        AlarmArray[AlarmCount] = i;
                        AlarmCount++;
                    }
                }
            }
            catch (Exception e)
            {
                //return;
            }

            if (AlarmCount > 0)
            {
                if (m_count2 < 2)
                    m_count2++;
                else
                {
                    m_count2 = 0;
                    //FormHMI.m_FormHMI.fALAMPLC("警告", 1, AlarmCount);
                }
            }
            else
                m_count2 = 0;
        }
        /// <summary>
        /// PLCIOd读取
        /// </summary>
        public void fInputIOcheck() 
        { 
            //ADS通用IO
            AdsStream datastream = new AdsStream(16 * 10);
            AdsBinaryReader binread1 = new AdsBinaryReader(datastream);
            datastream.Position = 0;
            try
            {
                tcClient.Read(FormHMIReadhvar1, datastream);
                for(int i=1;i<=160;i++){
                    GlobalDefine.getInstance().stInpu[i] = binread1.ReadBoolean();
                }
            }
            catch(Exception ex)
            {
                //writeLog.ShowMessageToList("异常原因："+ex);
                return ;
            }           
        }
        /// <summary>
        /// 
        /// </summary>
        public void fWriteparamToPlc()
        {

            float[] PlcParam = new float[151];
            for (int i = 0; i < 151; i++)
            {
                PlcParam[i] = 0;
            }

            PlcParam[24] = (float)DataManage.getInstance().SysParamData.dbzApos;//上料回原点偏移

            try
            {
                int FormHMIReadWritehvar = tcClient.CreateVariableHandle(".MachinePar_HMI");  //写入PLC的数组变量名
                using (AdsStream datastream4 = new AdsStream(4 * 50))
                {
                    using (BinaryWriter binwrite4 = new BinaryWriter(datastream4))
                    {
                        datastream4.Position = 0;
                        for (int i = 0; i < 50; i++)
                            binwrite4.Write(PlcParam[i]);
                        tcClient.Write(FormHMIReadWritehvar, datastream4);
                        tcClient.DeleteVariableHandle(FormHMIReadWritehvar);
                    }
                }
            }
            catch
            {
                //ErrorDispose.getInstance().AddErrLog((int)TipsErrCode.TEC_SETPLCPARAMFAIL,"");
                return;
            }

            GlobalDefine.getInstance().m_SysParaSetFlag = true;
        }
        /// <summary>
        /// /
        /// </summary>
        /// <returns></returns>
        public bool fretplc() 
        {
            try
            {
               tcClient.WriteControl(new StateInfo(AdsState.Reset, tcClient.ReadState().DeviceState));
               DeleteTwinCATHanle();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }

}
