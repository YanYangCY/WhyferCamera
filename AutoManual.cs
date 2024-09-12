using DrlaserCutSystem.Handle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhyfdrCamera;
using ACS.SPiiPlusNET;      // ACS .NET Library
using DrlaserCutSystem.Handle;
using SimpleTCP;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace WhyferCamera
{
    public partial class AutoManual : Form
    {
        //public static AutoManual m_MainForm;
        //string RectResult;
        private System.Windows.Forms.RadioButton[] radioButtons; // 定义RadioButton数组
        public AutoManual()
        {
            InitializeComponent();
            DataManage.getInstance().SysParamData.LoadParams();
            this.Load += new System.EventHandler(this.AutoManual_Load);
            /*SimpleTcpClientInstance.DataReceived += (sender, data) =>
            {
                //RectResult = data;
                GlobalVariables.RectResult = data;
            };*/
            //radioButtons多选框数组表
            radioButtons = new System.Windows.Forms.RadioButton[]
            {
                A,
                B,
                C,
                D,
                A1,
                B1,
                C1,
                D1
            // 继续添加其他RadioButton控件
            };

        }

        /// <summary>
        /// 判断radioButtons多选框是否选中，返回Name
        /// </summary>
        /// <param name="radioButtons"></param>
        /// <returns></returns>
        private string  GetSelectedRadioButton(System.Windows.Forms.RadioButton[] radioButtons)
        {
            foreach (System.Windows.Forms.RadioButton rb in radioButtons)
            {
                if (rb.Checked)
                {
                    return rb.Name;
                }
            }
            return null;
        }

        /// <summary>
        /// TCP连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TCPConnect_Click(object sender, EventArgs e)
        {
            SimpleTcpClientInstance._tcpClient = null;
            SimpleTcpClient tcpClient = SimpleTcpClientInstance.TcpClient;

            if (SimpleTcpClientInstance.Connected)
            {
                //textBox1.Text = "success";
                label9.Text = "TCP已连接！";
            }
            else
            {
                //textBox1.Text = "flase";
            }
            SimpleTcpClientInstance.SendData("TCP已连接");
        }
        /// <summary>
        /// TCP断开连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TCPDisConnect_Click(object sender, EventArgs e)
        {
            if (SimpleTcpClientInstance.Connected)
            {
                SimpleTcpClientInstance.SendData("TCP连接已断开");
                SimpleTcpClientInstance.Disconnect();
                label9.Text = "TCP连接已断开！";
            }
            else
            {
            }
        }
        

        /// <summary>
        /// ACS连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ACSConnect_Click(object sender, EventArgs e)
        {
            if (ACSHandle.getInstance().init())
            {
                //ErrorDispose.getInstance().AddErrLog((int)TipsErrCode.TEC_CONNECTPLCSUC, "");

                ACSConnect.Enabled = false;
                ACSDisConnect.Enabled = true;
                ACSConnectLabel.Text = "ACS已连接！";
            }
            else
            {
                //ErrorDispose.getInstance().AddErrLog((int)TipsErrCode.TEC_CONNECTPLCFAIL, "");
                ACSConnect.Enabled = true;
                ACSDisConnect.Enabled = false;
                
            }
        }

        /// <summary>
        /// ACS断开连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ACSDisConnect_Click(object sender, EventArgs e)
        {
            ACSHandle.getInstance().fAcsDisconnect();
            ACSConnect.Enabled = true;
            ACSDisConnect.Enabled = false;
            ACSConnectLabel.Text = "ACS已断开！";
        }

        /// <summary>
        /// 运动时加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoManual_Load(object sender, EventArgs e)
        {
            ACSHandle.getInstance().init();
            this.Invoke(new Action(() =>
            {
                for (int i = 0; i < ACSHandle.getInstance().m_nTotalBuffer; i++)
                {
                    //cboBufferNo.Items.Add(i.ToString());
                }
                //cboBufferNo.SelectedIndex = 0;

                textXSpeed.Text = DataManage.getInstance().SysParamData.dbXSpeed.ToString();
                textXAcc.Text = DataManage.getInstance().SysParamData.dbXAcc.ToString();
                textYSpeed.Text = DataManage.getInstance().SysParamData.dbYSpeed.ToString();
                textYAcc.Text = DataManage.getInstance().SysParamData.dbYAcc.ToString();

                textRSpeed.Text = DataManage.getInstance().SysParamData.dbRSpeed.ToString();
                textRAcc.Text = DataManage.getInstance().SysParamData.dbRAcc.ToString();

             
            }));
        }

        /// <summary>
        /// X轴参数保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveX_Click(object sender, EventArgs e)
        {
            DataManage.getInstance().SysParamData.dbXSpeed = GlobalMethod.getInstance().StringToDouble(textXSpeed.Text, 0.0);
            DataManage.getInstance().SysParamData.dbXAcc = GlobalMethod.getInstance().StringToDouble(textXAcc.Text, 0.0);
            DataManage.getInstance().SysParamData.SaveParams();
        }
        /// <summary>
        /// Y轴参数保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveY_Click(object sender, EventArgs e)
        {
            DataManage.getInstance().SysParamData.dbYSpeed = GlobalMethod.getInstance().StringToDouble(textYSpeed.Text, 0.0);
            DataManage.getInstance().SysParamData.dbYAcc = GlobalMethod.getInstance().StringToDouble(textYAcc.Text, 0.0);
            DataManage.getInstance().SysParamData.SaveParams();
        }
        /// <summary>
        /// R轴参数保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveR_Click(object sender, EventArgs e)
        {
            DataManage.getInstance().SysParamData.dbRSpeed = GlobalMethod.getInstance().StringToDouble(textRSpeed.Text, 0.0);
            DataManage.getInstance().SysParamData.dbRAcc = GlobalMethod.getInstance().StringToDouble(textRAcc.Text, 0.0);
            DataManage.getInstance().SysParamData.SaveParams();
        }

        /// <summary>
        /// Xabs绝对位移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXMoveAbs_Click(object sender, EventArgs e)
        {
            if (ACSHandle.getInstance().fGetAcsConnnectStu())
            {
                try
                {
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0, Convert.ToDouble(textXMoveAbs.Text), DataManage.getInstance().SysParamData.dbXSpeed);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Yabs绝对位移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYMoveAbs_Click(object sender, EventArgs e)
        {
            if (ACSHandle.getInstance().fGetAcsConnnectStu())
            {
                try
                {
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1, Convert.ToDouble(textYMoveAbs.Text), DataManage.getInstance().SysParamData.dbYSpeed);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Rabs绝对位移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRMoveAbs_Click(object sender, EventArgs e)
        {
            if (ACSHandle.getInstance().fGetAcsConnnectStu())
            {
                try
                {
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_2, Convert.ToDouble(textRMoveAbs.Text), DataManage.getInstance().SysParamData.dbRSpeed);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// IO定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerIO_Tick(object senSder, EventArgs e)
        {
            if (ACSHandle.getInstance().fGetAcsConnnectStu())
            {
                if (Math.Abs(ACSHandle.getInstance().fGetAxisPos(ACS.SPiiPlusNET.Axis.ACSC_AXIS_0) - GlobalMethod.getInstance().StringToDouble(textXPos.Text, 0.0)) > 0.001)
                {
                    textXPos.Text = ACSHandle.getInstance().fGetAxisPos(ACS.SPiiPlusNET.Axis.ACSC_AXIS_0).ToString("0.0000");
                }
                if (Math.Abs(ACSHandle.getInstance().fGetAxisPos(ACS.SPiiPlusNET.Axis.ACSC_AXIS_1) - GlobalMethod.getInstance().StringToDouble(textYPos.Text, 0.0)) > 0.001)
                {
                    textYPos.Text = ACSHandle.getInstance().fGetAxisPos(ACS.SPiiPlusNET.Axis.ACSC_AXIS_1).ToString("0.0000");
                }

                if (Math.Abs(ACSHandle.getInstance().fGetAxisPos(ACS.SPiiPlusNET.Axis.ACSC_AXIS_2) - GlobalMethod.getInstance().StringToDouble(textRPos.Text, 0.0)) > 0.001)
                {
                    textRPos.Text = ACSHandle.getInstance().fGetAxisPos(ACS.SPiiPlusNET.Axis.ACSC_AXIS_2).ToString("0.0000");
                }
            }
            //if (HandleTinCAT.getInstance().fGetInitStatus())
                //textBox4.Text = Convert.ToDouble(HandleTinCAT.getInstance().fReadFromPlc(".g_Zrealpos")).ToString("0.0000");
        }

        /// <summary>
        /// 上位错误处理
        /// </summary>
        /// <param name="title"></param>
        /// <param name="flag"></param>
        /// <param name="AlarmCount"></param>
        public void fALAMHMI(string title, uint flag, int Alarmcode)
        {
            string message = null;
            GlobalDefine.getInstance().g_AlarmStu = true;
            if (Alarmcode != -1)
                message += /*"NO" + Alarmcode + ":" +*/ ErrorDispose.getInstance().mapErrCfg[Alarmcode].strContent + "\n";
            else
                message += "未找到报警代码，请检查！\n";
            //if ((flag == 1))
            //    HandleTinCAT.getInstance().fWriteToPlc(".g_bHMI_To_Plc_Alarm", true);

            if (flag == 3)
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));

            else
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            //if ((flag == 1))
            //    HandleTinCAT.getInstance().fWriteToPlc(".g_bHMI_To_Plc_Alarm", false);
            GlobalDefine.getInstance().g_AlarmStu = false;
            //ErrorDispose.getInstance().AddErrLog(Alarmcode, "");
        }

        /// <summary>
        /// 执行相机九点标定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonCalinbrationStart_Click(object sender, EventArgs e)
        {
            var PointName = GetSelectedRadioButton(radioButtons);   // 判断当前点位是否选择
            if (SimpleTcpClientInstance.Connected && !ACSConnect.Enabled && PointName != null
                && !string.IsNullOrEmpty(textBoxCalinbrationX.Text) && !string.IsNullOrEmpty(textBoxCalinbrationY.Text))//&& ACSDisConnect.Enabled
            /*if (SimpleTcpClientInstance.Connected
                && !string.IsNullOrEmpty(textBoxCalinbrationX.Text) && !string.IsNullOrEmpty(textBoxCalinbrationY.Text))*/
            {
                buttonCalinbrationStart.Text = "正在执行九点标定!";
                Application.DoEvents(); // 允许UI更新
                int flagCali = 1;   // 九点标定标志位
                var CenterX = Convert.ToDouble(textBoxCalinbrationX.Text);
                var CenterY = Convert.ToDouble(textBoxCalinbrationY.Text);
                var CaliX1 = CenterX - 1; var CaliY1 = CenterY - 1; // 九点第一点
                var CaliX2 = CenterX    ; var CaliY2 = CenterY - 1; // 九点第二点
                var CaliX3 = CenterX + 1; var CaliY3 = CenterY - 1; // 九点第三点
                var CaliX4 = CenterX + 1; var CaliY4 = CenterY    ; // 九点第四点
                var CaliX6 = CenterX - 1; var CaliY6 = CenterY    ; // 九点第六点
                var CaliX7 = CenterX - 1; var CaliY7 = CenterY + 1; // 九点第七点
                var CaliX8 = CenterX    ; var CaliY8 = CenterY + 1; // 九点第八点
                var CaliX9 = CenterX + 1; var CaliY9 = CenterY + 1; // 九点第九点
                if (flagCali == 1)  // 九点第一点
                {
                    
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0, 
                        CaliX1, DataManage.getInstance().SysParamData.dbXSpeed);
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1, 
                        CaliY1, DataManage.getInstance().SysParamData.dbYSpeed);
                    SimpleTcpClientInstance.SendData($"Calinbration,OverPrint,{PointName},{CaliX1},{CaliY1}");
                    
                    while (GlobalVariables.RectResult != "OK")
                    {
                        
                    }                   
                    CaliPoint1.ForeColor = Color.Green;
                    flagCali += 1;
                    GlobalVariables.RectResult = null;
                    Application.DoEvents(); // 允许UI更新
                    System.Threading.Thread.Sleep(100); // 延时100ms
                }
                
                if (flagCali == 2)  // 九点第二点
                {
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0, 
                        CaliX2, DataManage.getInstance().SysParamData.dbXSpeed);
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1, 
                        CaliY2, DataManage.getInstance().SysParamData.dbYSpeed);
                    SimpleTcpClientInstance.SendData($"Calinbration,OverPrint,{PointName},{CaliX2},{CaliY2}");

                    while (GlobalVariables.RectResult != "OK")
                    {

                    }
                    CaliPoint2.ForeColor = Color.Green;
                    flagCali += 1;
                    GlobalVariables.RectResult = null;
                    Application.DoEvents(); // 允许UI更新
                    System.Threading.Thread.Sleep(100); // 延时100ms
                }
                if (flagCali == 3)  // 九点第三点
                {
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0, 
                        CaliX3, DataManage.getInstance().SysParamData.dbXSpeed);
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1, 
                        CaliY3, DataManage.getInstance().SysParamData.dbYSpeed);
                    SimpleTcpClientInstance.SendData($"Calinbration,OverPrint,{PointName},{CaliX3},{CaliY3}");

                    while (GlobalVariables.RectResult != "OK")
                    {

                    }
                    CaliPoint3.ForeColor = Color.Green;
                    flagCali += 1;
                    GlobalVariables.RectResult = null;
                    Application.DoEvents(); // 允许UI更新
                    System.Threading.Thread.Sleep(100); // 延时100ms
                }
                if (flagCali == 4)  // 九点第四点
                {
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0,
                        CaliX4, DataManage.getInstance().SysParamData.dbXSpeed);
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1,
                        CaliY4, DataManage.getInstance().SysParamData.dbYSpeed);
                    SimpleTcpClientInstance.SendData($"Calinbration,OverPrint,{PointName},{CaliX4},{CaliY4}");

                    while (GlobalVariables.RectResult != "OK")
                    {

                    }
                    CaliPoint4.ForeColor = Color.Green;
                    flagCali += 1;
                    GlobalVariables.RectResult = null;
                    Application.DoEvents(); // 允许UI更新
                    System.Threading.Thread.Sleep(100); // 延时100ms
                }
                if (flagCali == 5)  // 九点第五点
                {
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0,
                        CenterX, DataManage.getInstance().SysParamData.dbXSpeed);
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1,
                        CenterY, DataManage.getInstance().SysParamData.dbYSpeed);
                    SimpleTcpClientInstance.SendData($"Calinbration,OverPrint,{PointName},{CenterX},{CenterY}");

                    while (GlobalVariables.RectResult != "OK")
                    {

                    }
                    CaliPoint5.ForeColor = Color.Green;
                    flagCali += 1;
                    GlobalVariables.RectResult = null;
                    Application.DoEvents(); // 允许UI更新
                    System.Threading.Thread.Sleep(100); // 延时100ms
                }
                if (flagCali == 6)  // 九点第六点
                {
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0,
                        CaliX6, DataManage.getInstance().SysParamData.dbXSpeed);
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1,
                        CaliY6, DataManage.getInstance().SysParamData.dbYSpeed);
                    SimpleTcpClientInstance.SendData($"Calinbration,OverPrint,{PointName},{CaliX6},{CaliY6}");

                    while (GlobalVariables.RectResult != "OK")
                    {

                    }
                    CaliPoint6.ForeColor = Color.Green;
                    flagCali += 1;
                    GlobalVariables.RectResult = null;
                    Application.DoEvents(); // 允许UI更新
                    System.Threading.Thread.Sleep(100); // 延时100ms
                }
                if (flagCali == 7)  // 九点第七点
                {
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0,
                        CaliX7, DataManage.getInstance().SysParamData.dbXSpeed);
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1,
                        CaliY7, DataManage.getInstance().SysParamData.dbYSpeed);
                    SimpleTcpClientInstance.SendData($"Calinbration,OverPrint,{PointName},{CaliX7},{CaliY7}");

                    while (GlobalVariables.RectResult != "OK")
                    {

                    }
                    CaliPoint7.ForeColor = Color.Green;
                    flagCali += 1;
                    GlobalVariables.RectResult = null;
                    Application.DoEvents(); // 允许UI更新
                    System.Threading.Thread.Sleep(100); // 延时100ms
                }
                if (flagCali == 8)  // 九点第八点
                {
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0,
                        CaliX8, DataManage.getInstance().SysParamData.dbXSpeed);
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1,
                        CaliY8, DataManage.getInstance().SysParamData.dbYSpeed);
                    SimpleTcpClientInstance.SendData($"Calinbration,OverPrint,{PointName},{CaliX8},{CaliY8}");

                    while (GlobalVariables.RectResult != "OK")
                    {

                    }
                    CaliPoint8.ForeColor = Color.Green;
                    flagCali += 1;
                    GlobalVariables.RectResult = null;
                    Application.DoEvents(); // 允许UI更新
                    System.Threading.Thread.Sleep(100); // 延时100ms
                }
                if (flagCali == 9)  // 九点第九点
                {
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0,
                        CaliX9, DataManage.getInstance().SysParamData.dbXSpeed);
                    ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1,
                        CaliY9, DataManage.getInstance().SysParamData.dbYSpeed);
                    SimpleTcpClientInstance.SendData($"Calinbration,OverPrint,{PointName},{CaliX9},{CaliY9}");

                    while (GlobalVariables.RectResult != "OK")
                    {

                    }
                    CaliPoint9.ForeColor = Color.Green;
                    flagCali += 1;
                    GlobalVariables.RectResult = null;
                    Application.DoEvents(); // 允许UI更新
                    System.Threading.Thread.Sleep(100); // 延时100ms
                    buttonCalinbrationStart.Text = "标定结束!";
                    Application.DoEvents(); // 允许UI更新
                }


                
            }
            else
            {
                buttonCalinbrationStart.Text = "通讯/中心点数值异常!";
                buttonCalinbrationStart.ForeColor = Color.Red;
                CaliPoint1.ForeColor = Color.Green;
            }
        }

        /// <summary>
        /// 执行平台的旋转标定步骤1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonCalinbrationAngle1_Click(object sender, EventArgs e)
        {
            if (SimpleTcpClientInstance.Connected && !ACSConnect.Enabled
                && !string.IsNullOrEmpty(textBoxAngleX.Text) && !string.IsNullOrEmpty(textBoxAngleY.Text))
            {
                var CenterX = Convert.ToDouble(textBoxAngleX.Text);
                var CenterY = Convert.ToDouble(textBoxAngleY.Text);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0,
                    CenterX, DataManage.getInstance().SysParamData.dbXSpeed);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1,
                    CenterY, DataManage.getInstance().SysParamData.dbYSpeed);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_2, 
                    0, DataManage.getInstance().SysParamData.dbRSpeed);
                buttonAngle1.ForeColor = Color.Green;              
                Application.DoEvents(); // 允许UI更新
                // SimpleTcpClientInstance.SendData($"Calinbration,OverPrint,{PointName},{CaliX1},{CaliY1}");
            }

        }
        /// <summary>
        /// 执行平台的旋转标定步骤2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonCalinbrationAngle2_Click(object sender, EventArgs e)
        {
            ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_2,
                    -2, DataManage.getInstance().SysParamData.dbRSpeed);
            SimpleTcpClientInstance.SendData($"Calinbration,Angle,0,4");
            while (GlobalVariables.RectResult != "OK")
            {
            }
            buttonAngle2.ForeColor = Color.Green;
            Application.DoEvents(); // 允许UI更新
        }
        /// <summary>
        /// 执行平台的旋转标定步骤3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonCalinbrationAngle3_Click(object sender, EventArgs e)
        {
            ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_2,
                    2, DataManage.getInstance().SysParamData.dbRSpeed);
            SimpleTcpClientInstance.SendData($"Calinbration,Angle,1,4");
            while (GlobalVariables.RectResult != "OK")
            {
            }
            buttonAngle3.ForeColor = Color.Green;
            Application.DoEvents(); // 允许UI更新
        }

        /// <summary>
        /// 执行激光原点定位标定A1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonCalinbrationLaser1_Click(object sender, EventArgs e)
        {
            if (SimpleTcpClientInstance.Connected && !ACSConnect.Enabled
                && !string.IsNullOrEmpty(textBoxLaserX.Text) && !string.IsNullOrEmpty(textBoxLaserY.Text))
            {
                var CenterX = Convert.ToDouble(textBoxLaserX.Text);
                var CenterY = Convert.ToDouble(textBoxLaserY.Text);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0,
                    CenterX, DataManage.getInstance().SysParamData.dbXSpeed);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1,
                    CenterY, DataManage.getInstance().SysParamData.dbYSpeed);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_2,
                    0, DataManage.getInstance().SysParamData.dbRSpeed);
                SimpleTcpClientInstance.SendData($"Calinbration,Laser,A1");
                buttonCalinbrationLaserA1.ForeColor = Color.Green;
                CaliPointA1.ForeColor = Color.Green;                
                Application.DoEvents(); // 允许UI更新
            }

        }
        /// <summary>
        /// 执行激光原点定位标定B1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonCalinbrationLaser2_Click(object sender, EventArgs e)
        {
            if (SimpleTcpClientInstance.Connected && !ACSConnect.Enabled
                && !string.IsNullOrEmpty(textBoxLaserX.Text) && !string.IsNullOrEmpty(textBoxLaserY.Text))
            {
                var CenterX = Convert.ToDouble(textBoxLaserX.Text);
                var CenterY = Convert.ToDouble(textBoxLaserY.Text);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0,
                    CenterX, DataManage.getInstance().SysParamData.dbXSpeed);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1,
                    CenterY, DataManage.getInstance().SysParamData.dbYSpeed);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_2,
                    0, DataManage.getInstance().SysParamData.dbRSpeed);
                SimpleTcpClientInstance.SendData($"Calinbration,Laser,B1");
                buttonCalinbrationLaserB1.ForeColor = Color.Green;
                CaliPointB1.ForeColor = Color.Green;
                Application.DoEvents(); // 允许UI更新
            }

        }
        /// <summary>
        /// 执行激光原点定位标定C1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonCalinbrationLaser3_Click(object sender, EventArgs e)
        {
            if (SimpleTcpClientInstance.Connected && !ACSConnect.Enabled
                && !string.IsNullOrEmpty(textBoxLaserX.Text) && !string.IsNullOrEmpty(textBoxLaserY.Text))
            {
                var CenterX = Convert.ToDouble(textBoxLaserX.Text);
                var CenterY = Convert.ToDouble(textBoxLaserY.Text);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0,
                    CenterX, DataManage.getInstance().SysParamData.dbXSpeed);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1,
                    CenterY, DataManage.getInstance().SysParamData.dbYSpeed);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_2,
                    0, DataManage.getInstance().SysParamData.dbRSpeed);
                SimpleTcpClientInstance.SendData($"Calinbration,Laser,C1");
                buttonCalinbrationLaserC1.ForeColor = Color.Green;
                CaliPointC1.ForeColor = Color.Green;
                Application.DoEvents(); // 允许UI更新
            }

        }
        /// <summary>
        /// 执行激光原点定位标定D1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonCalinbrationLaser4_Click(object sender, EventArgs e)
        {
            if (SimpleTcpClientInstance.Connected && !ACSConnect.Enabled
                && !string.IsNullOrEmpty(textBoxLaserX.Text) && !string.IsNullOrEmpty(textBoxLaserY.Text))
            {
                var CenterX = Convert.ToDouble(textBoxLaserX.Text);
                var CenterY = Convert.ToDouble(textBoxLaserY.Text);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_0,
                    CenterX, DataManage.getInstance().SysParamData.dbXSpeed);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_1,
                    CenterY, DataManage.getInstance().SysParamData.dbYSpeed);
                ACSHandle.getInstance().fToPoint(0, ACS.SPiiPlusNET.Axis.ACSC_AXIS_2,
                    0, DataManage.getInstance().SysParamData.dbRSpeed);
                SimpleTcpClientInstance.SendData($"Calinbration,Laser,D1");
                buttonCalinbrationLaserD1.ForeColor = Color.Green;
                CaliPointD1.ForeColor = Color.Green;
                Application.DoEvents(); // 允许UI更新
            }

        }

    }
}
