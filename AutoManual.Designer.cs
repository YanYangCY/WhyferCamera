namespace WhyferCamera
{
    partial class AutoManual
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ACSConnect = new System.Windows.Forms.Button();
            this.ACSDisConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textXPos = new System.Windows.Forms.TextBox();
            this.textXSpeed = new System.Windows.Forms.TextBox();
            this.textXAcc = new System.Windows.Forms.TextBox();
            this.textYPos = new System.Windows.Forms.TextBox();
            this.textYSpeed = new System.Windows.Forms.TextBox();
            this.textYAcc = new System.Windows.Forms.TextBox();
            this.textRPos = new System.Windows.Forms.TextBox();
            this.textRSpeed = new System.Windows.Forms.TextBox();
            this.textRAcc = new System.Windows.Forms.TextBox();
            this.SaveX = new System.Windows.Forms.Button();
            this.SaveY = new System.Windows.Forms.Button();
            this.SaveR = new System.Windows.Forms.Button();
            this.timerIO = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.textXMoveAbs = new System.Windows.Forms.TextBox();
            this.textYMoveAbs = new System.Windows.Forms.TextBox();
            this.textRMoveAbs = new System.Windows.Forms.TextBox();
            this.btnXMoveAbs = new System.Windows.Forms.Button();
            this.btnYMoveAbs = new System.Windows.Forms.Button();
            this.btnRMoveAbs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ACSConnectLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TCPConnect = new System.Windows.Forms.Button();
            this.TCPDisConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CaliPoint7 = new System.Windows.Forms.Label();
            this.CaliPoint6 = new System.Windows.Forms.Label();
            this.CaliPoint8 = new System.Windows.Forms.Label();
            this.CaliPoint5 = new System.Windows.Forms.Label();
            this.CaliPoint9 = new System.Windows.Forms.Label();
            this.CaliPoint4 = new System.Windows.Forms.Label();
            this.CaliPoint3 = new System.Windows.Forms.Label();
            this.CaliPoint2 = new System.Windows.Forms.Label();
            this.CaliPoint1 = new System.Windows.Forms.Label();
            this.textBoxCalinbrationY = new System.Windows.Forms.TextBox();
            this.textBoxCalinbrationX = new System.Windows.Forms.TextBox();
            this.buttonCalinbrationStart = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.RadioButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.C = new System.Windows.Forms.RadioButton();
            this.D = new System.Windows.Forms.RadioButton();
            this.A1 = new System.Windows.Forms.RadioButton();
            this.B1 = new System.Windows.Forms.RadioButton();
            this.C1 = new System.Windows.Forms.RadioButton();
            this.D1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ACSConnect
            // 
            this.ACSConnect.BackColor = System.Drawing.Color.Chartreuse;
            this.ACSConnect.Location = new System.Drawing.Point(6, 20);
            this.ACSConnect.Name = "ACSConnect";
            this.ACSConnect.Size = new System.Drawing.Size(75, 23);
            this.ACSConnect.TabIndex = 0;
            this.ACSConnect.Text = "Connect";
            this.ACSConnect.UseVisualStyleBackColor = false;
            this.ACSConnect.Click += new System.EventHandler(this.ACSConnect_Click);
            // 
            // ACSDisConnect
            // 
            this.ACSDisConnect.BackColor = System.Drawing.Color.Red;
            this.ACSDisConnect.Location = new System.Drawing.Point(87, 20);
            this.ACSDisConnect.Name = "ACSDisConnect";
            this.ACSDisConnect.Size = new System.Drawing.Size(75, 23);
            this.ACSDisConnect.TabIndex = 1;
            this.ACSDisConnect.Text = "DisConnect";
            this.ACSDisConnect.UseVisualStyleBackColor = false;
            this.ACSDisConnect.Click += new System.EventHandler(this.ACSDisConnect_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "R";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "轴号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "位置";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "速度";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "加速度";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textXPos
            // 
            this.textXPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textXPos.Enabled = false;
            this.textXPos.Location = new System.Drawing.Point(75, 53);
            this.textXPos.Margin = new System.Windows.Forms.Padding(1);
            this.textXPos.Name = "textXPos";
            this.textXPos.Size = new System.Drawing.Size(104, 21);
            this.textXPos.TabIndex = 9;
            this.textXPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textXSpeed
            // 
            this.textXSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textXSpeed.Location = new System.Drawing.Point(183, 53);
            this.textXSpeed.Margin = new System.Windows.Forms.Padding(1);
            this.textXSpeed.Name = "textXSpeed";
            this.textXSpeed.Size = new System.Drawing.Size(104, 21);
            this.textXSpeed.TabIndex = 9;
            this.textXSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textXAcc
            // 
            this.textXAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textXAcc.Location = new System.Drawing.Point(291, 53);
            this.textXAcc.Margin = new System.Windows.Forms.Padding(1);
            this.textXAcc.Name = "textXAcc";
            this.textXAcc.Size = new System.Drawing.Size(104, 21);
            this.textXAcc.TabIndex = 9;
            this.textXAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textYPos
            // 
            this.textYPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textYPos.Enabled = false;
            this.textYPos.Location = new System.Drawing.Point(75, 95);
            this.textYPos.Margin = new System.Windows.Forms.Padding(1);
            this.textYPos.Name = "textYPos";
            this.textYPos.Size = new System.Drawing.Size(104, 21);
            this.textYPos.TabIndex = 9;
            this.textYPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textYSpeed
            // 
            this.textYSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textYSpeed.Location = new System.Drawing.Point(183, 95);
            this.textYSpeed.Margin = new System.Windows.Forms.Padding(1);
            this.textYSpeed.Name = "textYSpeed";
            this.textYSpeed.Size = new System.Drawing.Size(104, 21);
            this.textYSpeed.TabIndex = 9;
            this.textYSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textYAcc
            // 
            this.textYAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textYAcc.Location = new System.Drawing.Point(291, 95);
            this.textYAcc.Margin = new System.Windows.Forms.Padding(1);
            this.textYAcc.Name = "textYAcc";
            this.textYAcc.Size = new System.Drawing.Size(104, 21);
            this.textYAcc.TabIndex = 9;
            this.textYAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textRPos
            // 
            this.textRPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textRPos.Enabled = false;
            this.textRPos.Location = new System.Drawing.Point(75, 137);
            this.textRPos.Margin = new System.Windows.Forms.Padding(1);
            this.textRPos.Name = "textRPos";
            this.textRPos.Size = new System.Drawing.Size(104, 21);
            this.textRPos.TabIndex = 9;
            this.textRPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textRSpeed
            // 
            this.textRSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textRSpeed.Location = new System.Drawing.Point(183, 137);
            this.textRSpeed.Margin = new System.Windows.Forms.Padding(1);
            this.textRSpeed.Name = "textRSpeed";
            this.textRSpeed.Size = new System.Drawing.Size(104, 21);
            this.textRSpeed.TabIndex = 9;
            this.textRSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textRAcc
            // 
            this.textRAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textRAcc.Location = new System.Drawing.Point(291, 137);
            this.textRAcc.Margin = new System.Windows.Forms.Padding(1);
            this.textRAcc.Name = "textRAcc";
            this.textRAcc.Size = new System.Drawing.Size(104, 21);
            this.textRAcc.TabIndex = 9;
            this.textRAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveX
            // 
            this.SaveX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveX.Location = new System.Drawing.Point(399, 53);
            this.SaveX.Margin = new System.Windows.Forms.Padding(1);
            this.SaveX.Name = "SaveX";
            this.SaveX.Size = new System.Drawing.Size(68, 21);
            this.SaveX.TabIndex = 10;
            this.SaveX.Text = "Save";
            this.SaveX.UseVisualStyleBackColor = true;
            this.SaveX.Click += new System.EventHandler(this.SaveX_Click);
            // 
            // SaveY
            // 
            this.SaveY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveY.Location = new System.Drawing.Point(399, 95);
            this.SaveY.Margin = new System.Windows.Forms.Padding(1);
            this.SaveY.Name = "SaveY";
            this.SaveY.Size = new System.Drawing.Size(68, 21);
            this.SaveY.TabIndex = 10;
            this.SaveY.Text = "Save";
            this.SaveY.UseVisualStyleBackColor = true;
            this.SaveY.Click += new System.EventHandler(this.SaveY_Click);
            // 
            // SaveR
            // 
            this.SaveR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveR.Location = new System.Drawing.Point(399, 137);
            this.SaveR.Margin = new System.Windows.Forms.Padding(1);
            this.SaveR.Name = "SaveR";
            this.SaveR.Size = new System.Drawing.Size(68, 21);
            this.SaveR.TabIndex = 10;
            this.SaveR.Text = "Save";
            this.SaveR.UseVisualStyleBackColor = true;
            this.SaveR.Click += new System.EventHandler(this.SaveR_Click);
            // 
            // timerIO
            // 
            this.timerIO.Enabled = true;
            this.timerIO.Interval = 20;
            this.timerIO.Tick += new System.EventHandler(this.timerIO_Tick);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "绝对移动";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textXMoveAbs
            // 
            this.textXMoveAbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textXMoveAbs.Location = new System.Drawing.Point(471, 53);
            this.textXMoveAbs.Margin = new System.Windows.Forms.Padding(1);
            this.textXMoveAbs.Name = "textXMoveAbs";
            this.textXMoveAbs.Size = new System.Drawing.Size(104, 21);
            this.textXMoveAbs.TabIndex = 12;
            this.textXMoveAbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textYMoveAbs
            // 
            this.textYMoveAbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textYMoveAbs.Location = new System.Drawing.Point(471, 95);
            this.textYMoveAbs.Margin = new System.Windows.Forms.Padding(1);
            this.textYMoveAbs.Name = "textYMoveAbs";
            this.textYMoveAbs.Size = new System.Drawing.Size(104, 21);
            this.textYMoveAbs.TabIndex = 12;
            this.textYMoveAbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textRMoveAbs
            // 
            this.textRMoveAbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textRMoveAbs.Location = new System.Drawing.Point(471, 137);
            this.textRMoveAbs.Margin = new System.Windows.Forms.Padding(1);
            this.textRMoveAbs.Name = "textRMoveAbs";
            this.textRMoveAbs.Size = new System.Drawing.Size(104, 21);
            this.textRMoveAbs.TabIndex = 12;
            this.textRMoveAbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnXMoveAbs
            // 
            this.btnXMoveAbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXMoveAbs.Location = new System.Drawing.Point(579, 53);
            this.btnXMoveAbs.Margin = new System.Windows.Forms.Padding(1);
            this.btnXMoveAbs.Name = "btnXMoveAbs";
            this.btnXMoveAbs.Size = new System.Drawing.Size(72, 22);
            this.btnXMoveAbs.TabIndex = 13;
            this.btnXMoveAbs.Text = "运动";
            this.btnXMoveAbs.UseVisualStyleBackColor = true;
            this.btnXMoveAbs.Click += new System.EventHandler(this.btnXMoveAbs_Click);
            // 
            // btnYMoveAbs
            // 
            this.btnYMoveAbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYMoveAbs.Location = new System.Drawing.Point(579, 95);
            this.btnYMoveAbs.Margin = new System.Windows.Forms.Padding(1);
            this.btnYMoveAbs.Name = "btnYMoveAbs";
            this.btnYMoveAbs.Size = new System.Drawing.Size(72, 22);
            this.btnYMoveAbs.TabIndex = 13;
            this.btnYMoveAbs.Text = "运动";
            this.btnYMoveAbs.UseVisualStyleBackColor = true;
            this.btnYMoveAbs.Click += new System.EventHandler(this.btnYMoveAbs_Click);
            // 
            // btnRMoveAbs
            // 
            this.btnRMoveAbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRMoveAbs.Location = new System.Drawing.Point(579, 137);
            this.btnRMoveAbs.Margin = new System.Windows.Forms.Padding(1);
            this.btnRMoveAbs.Name = "btnRMoveAbs";
            this.btnRMoveAbs.Size = new System.Drawing.Size(72, 22);
            this.btnRMoveAbs.TabIndex = 13;
            this.btnRMoveAbs.Text = "运动";
            this.btnRMoveAbs.UseVisualStyleBackColor = true;
            this.btnRMoveAbs.Click += new System.EventHandler(this.btnRMoveAbs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ACSConnectLabel);
            this.groupBox1.Controls.Add(this.ACSConnect);
            this.groupBox1.Controls.Add(this.ACSDisConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 74);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACS通讯连接";
            // 
            // ACSConnectLabel
            // 
            this.ACSConnectLabel.AutoSize = true;
            this.ACSConnectLabel.Location = new System.Drawing.Point(10, 51);
            this.ACSConnectLabel.Name = "ACSConnectLabel";
            this.ACSConnectLabel.Size = new System.Drawing.Size(71, 12);
            this.ACSConnectLabel.TabIndex = 2;
            this.ACSConnectLabel.Text = "ACS未连接！";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Controls.Add(this.SaveR, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SaveY, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRMoveAbs, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.textXSpeed, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnYMoveAbs, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.SaveX, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnXMoveAbs, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textRMoveAbs, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.textRAcc, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textYMoveAbs, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.textXAcc, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textXMoveAbs, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.textYAcc, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textYPos, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textRSpeed, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textYSpeed, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textRPos, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.textXPos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 170);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "保存参数";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(579, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "执行";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TCPConnect);
            this.groupBox2.Controls.Add(this.TCPDisConnect);
            this.groupBox2.Location = new System.Drawing.Point(220, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 74);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TCP通讯连接";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "TCP未连接！";
            // 
            // TCPConnect
            // 
            this.TCPConnect.BackColor = System.Drawing.Color.Chartreuse;
            this.TCPConnect.Location = new System.Drawing.Point(6, 20);
            this.TCPConnect.Name = "TCPConnect";
            this.TCPConnect.Size = new System.Drawing.Size(75, 23);
            this.TCPConnect.TabIndex = 0;
            this.TCPConnect.Text = "Connect";
            this.TCPConnect.UseVisualStyleBackColor = false;
            this.TCPConnect.Click += new System.EventHandler(this.TCPConnect_Click);
            // 
            // TCPDisConnect
            // 
            this.TCPDisConnect.BackColor = System.Drawing.Color.Red;
            this.TCPDisConnect.Location = new System.Drawing.Point(87, 20);
            this.TCPDisConnect.Name = "TCPDisConnect";
            this.TCPDisConnect.Size = new System.Drawing.Size(75, 23);
            this.TCPDisConnect.TabIndex = 1;
            this.TCPDisConnect.Text = "DisConnect";
            this.TCPDisConnect.UseVisualStyleBackColor = false;
            this.TCPDisConnect.Click += new System.EventHandler(this.TCPDisConnect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(12, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(666, 196);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACS运动坐标";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.CaliPoint7);
            this.groupBox4.Controls.Add(this.CaliPoint6);
            this.groupBox4.Controls.Add(this.CaliPoint8);
            this.groupBox4.Controls.Add(this.CaliPoint5);
            this.groupBox4.Controls.Add(this.CaliPoint9);
            this.groupBox4.Controls.Add(this.CaliPoint4);
            this.groupBox4.Controls.Add(this.CaliPoint3);
            this.groupBox4.Controls.Add(this.CaliPoint2);
            this.groupBox4.Controls.Add(this.CaliPoint1);
            this.groupBox4.Controls.Add(this.textBoxCalinbrationY);
            this.groupBox4.Controls.Add(this.textBoxCalinbrationX);
            this.groupBox4.Controls.Add(this.buttonCalinbrationStart);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(12, 304);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 200);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "九点标定";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.Control;
            this.label25.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(27, 153);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 20);
            this.label25.TabIndex = 3;
            this.label25.Text = "↓";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(124, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 20);
            this.label17.TabIndex = 3;
            this.label17.Text = "↓";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.Control;
            this.label23.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(50, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 20);
            this.label23.TabIndex = 3;
            this.label23.Text = "←";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.Control;
            this.label22.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(99, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 20);
            this.label22.TabIndex = 3;
            this.label22.Text = "←";
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.SystemColors.Control;
            this.label30.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label30.Location = new System.Drawing.Point(99, 173);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 20);
            this.label30.TabIndex = 3;
            this.label30.Text = "→";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.SystemColors.Control;
            this.label29.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(98, 173);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 20);
            this.label29.TabIndex = 3;
            this.label29.Text = "→";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(99, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 20);
            this.label19.TabIndex = 3;
            this.label19.Text = "→";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.Control;
            this.label27.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label27.Location = new System.Drawing.Point(50, 173);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 20);
            this.label27.TabIndex = 3;
            this.label27.Text = "→";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(50, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "→";
            // 
            // CaliPoint7
            // 
            this.CaliPoint7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaliPoint7.AutoSize = true;
            this.CaliPoint7.BackColor = System.Drawing.SystemColors.Control;
            this.CaliPoint7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaliPoint7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CaliPoint7.Location = new System.Drawing.Point(30, 173);
            this.CaliPoint7.Name = "CaliPoint7";
            this.CaliPoint7.Size = new System.Drawing.Size(22, 20);
            this.CaliPoint7.TabIndex = 3;
            this.CaliPoint7.Text = "◉";
            // 
            // CaliPoint6
            // 
            this.CaliPoint6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaliPoint6.AutoSize = true;
            this.CaliPoint6.BackColor = System.Drawing.SystemColors.Control;
            this.CaliPoint6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaliPoint6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CaliPoint6.Location = new System.Drawing.Point(30, 128);
            this.CaliPoint6.Name = "CaliPoint6";
            this.CaliPoint6.Size = new System.Drawing.Size(22, 20);
            this.CaliPoint6.TabIndex = 3;
            this.CaliPoint6.Text = "◉";
            // 
            // CaliPoint8
            // 
            this.CaliPoint8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaliPoint8.AutoSize = true;
            this.CaliPoint8.BackColor = System.Drawing.SystemColors.Control;
            this.CaliPoint8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaliPoint8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CaliPoint8.Location = new System.Drawing.Point(78, 173);
            this.CaliPoint8.Name = "CaliPoint8";
            this.CaliPoint8.Size = new System.Drawing.Size(22, 20);
            this.CaliPoint8.TabIndex = 3;
            this.CaliPoint8.Text = "◉";
            // 
            // CaliPoint5
            // 
            this.CaliPoint5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaliPoint5.AutoSize = true;
            this.CaliPoint5.BackColor = System.Drawing.SystemColors.Control;
            this.CaliPoint5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaliPoint5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CaliPoint5.Location = new System.Drawing.Point(78, 128);
            this.CaliPoint5.Name = "CaliPoint5";
            this.CaliPoint5.Size = new System.Drawing.Size(22, 20);
            this.CaliPoint5.TabIndex = 3;
            this.CaliPoint5.Text = "◉";
            // 
            // CaliPoint9
            // 
            this.CaliPoint9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaliPoint9.AutoSize = true;
            this.CaliPoint9.BackColor = System.Drawing.SystemColors.Control;
            this.CaliPoint9.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaliPoint9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CaliPoint9.Location = new System.Drawing.Point(127, 173);
            this.CaliPoint9.Name = "CaliPoint9";
            this.CaliPoint9.Size = new System.Drawing.Size(22, 20);
            this.CaliPoint9.TabIndex = 3;
            this.CaliPoint9.Text = "◉";
            // 
            // CaliPoint4
            // 
            this.CaliPoint4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaliPoint4.AutoSize = true;
            this.CaliPoint4.BackColor = System.Drawing.SystemColors.Control;
            this.CaliPoint4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaliPoint4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CaliPoint4.Location = new System.Drawing.Point(127, 128);
            this.CaliPoint4.Name = "CaliPoint4";
            this.CaliPoint4.Size = new System.Drawing.Size(22, 20);
            this.CaliPoint4.TabIndex = 3;
            this.CaliPoint4.Text = "◉";
            // 
            // CaliPoint3
            // 
            this.CaliPoint3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaliPoint3.AutoSize = true;
            this.CaliPoint3.BackColor = System.Drawing.SystemColors.Control;
            this.CaliPoint3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaliPoint3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CaliPoint3.Location = new System.Drawing.Point(127, 81);
            this.CaliPoint3.Name = "CaliPoint3";
            this.CaliPoint3.Size = new System.Drawing.Size(22, 20);
            this.CaliPoint3.TabIndex = 3;
            this.CaliPoint3.Text = "◉";
            // 
            // CaliPoint2
            // 
            this.CaliPoint2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaliPoint2.AutoSize = true;
            this.CaliPoint2.BackColor = System.Drawing.SystemColors.Control;
            this.CaliPoint2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaliPoint2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CaliPoint2.Location = new System.Drawing.Point(78, 81);
            this.CaliPoint2.Name = "CaliPoint2";
            this.CaliPoint2.Size = new System.Drawing.Size(22, 20);
            this.CaliPoint2.TabIndex = 3;
            this.CaliPoint2.Text = "◉";
            // 
            // CaliPoint1
            // 
            this.CaliPoint1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaliPoint1.AutoSize = true;
            this.CaliPoint1.BackColor = System.Drawing.SystemColors.Control;
            this.CaliPoint1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaliPoint1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CaliPoint1.Location = new System.Drawing.Point(30, 81);
            this.CaliPoint1.Name = "CaliPoint1";
            this.CaliPoint1.Size = new System.Drawing.Size(22, 20);
            this.CaliPoint1.TabIndex = 3;
            this.CaliPoint1.Text = "◉";
            // 
            // textBoxCalinbrationY
            // 
            this.textBoxCalinbrationY.Location = new System.Drawing.Point(108, 22);
            this.textBoxCalinbrationY.Name = "textBoxCalinbrationY";
            this.textBoxCalinbrationY.Size = new System.Drawing.Size(65, 21);
            this.textBoxCalinbrationY.TabIndex = 2;
            // 
            // textBoxCalinbrationX
            // 
            this.textBoxCalinbrationX.Location = new System.Drawing.Point(24, 22);
            this.textBoxCalinbrationX.Name = "textBoxCalinbrationX";
            this.textBoxCalinbrationX.Size = new System.Drawing.Size(65, 21);
            this.textBoxCalinbrationX.TabIndex = 1;
            // 
            // buttonCalinbrationStart
            // 
            this.buttonCalinbrationStart.Location = new System.Drawing.Point(11, 49);
            this.buttonCalinbrationStart.Name = "buttonCalinbrationStart";
            this.buttonCalinbrationStart.Size = new System.Drawing.Size(162, 23);
            this.buttonCalinbrationStart.TabIndex = 0;
            this.buttonCalinbrationStart.Text = "输入中心点后执行";
            this.buttonCalinbrationStart.UseVisualStyleBackColor = true;
            this.buttonCalinbrationStart.Click += new System.EventHandler(this.buttonCalinbrationStart_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(93, 30);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "Y";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "X";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(3, 2);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(29, 16);
            this.A.TabIndex = 19;
            this.A.TabStop = true;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(3, 25);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(29, 16);
            this.B.TabIndex = 20;
            this.B.TabStop = true;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(3, 47);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(29, 16);
            this.C.TabIndex = 20;
            this.C.TabStop = true;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(3, 69);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(29, 16);
            this.D.TabIndex = 20;
            this.D.TabStop = true;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            // 
            // A1
            // 
            this.A1.AutoSize = true;
            this.A1.Location = new System.Drawing.Point(3, 91);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(35, 16);
            this.A1.TabIndex = 20;
            this.A1.TabStop = true;
            this.A1.Text = "A1";
            this.A1.UseVisualStyleBackColor = true;
            // 
            // B1
            // 
            this.B1.AutoSize = true;
            this.B1.Location = new System.Drawing.Point(3, 113);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(35, 16);
            this.B1.TabIndex = 20;
            this.B1.TabStop = true;
            this.B1.Text = "B1";
            this.B1.UseVisualStyleBackColor = true;
            // 
            // C1
            // 
            this.C1.AutoSize = true;
            this.C1.Location = new System.Drawing.Point(3, 135);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(35, 16);
            this.C1.TabIndex = 20;
            this.C1.TabStop = true;
            this.C1.Text = "C1";
            this.C1.UseVisualStyleBackColor = true;
            // 
            // D1
            // 
            this.D1.AutoSize = true;
            this.D1.Location = new System.Drawing.Point(3, 157);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(35, 16);
            this.D1.TabIndex = 20;
            this.D1.TabStop = true;
            this.D1.Text = "D1";
            this.D1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.D);
            this.panel1.Controls.Add(this.D1);
            this.panel1.Controls.Add(this.A);
            this.panel1.Controls.Add(this.C1);
            this.panel1.Controls.Add(this.B);
            this.panel1.Controls.Add(this.B1);
            this.panel1.Controls.Add(this.C);
            this.panel1.Controls.Add(this.A1);
            this.panel1.Location = new System.Drawing.Point(191, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 173);
            this.panel1.TabIndex = 21;
            // 
            // AutoManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 516);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AutoManual";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ACSConnect;
        private System.Windows.Forms.Button ACSDisConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textXPos;
        private System.Windows.Forms.TextBox textXSpeed;
        private System.Windows.Forms.TextBox textXAcc;
        private System.Windows.Forms.TextBox textYPos;
        private System.Windows.Forms.TextBox textYSpeed;
        private System.Windows.Forms.TextBox textYAcc;
        private System.Windows.Forms.TextBox textRPos;
        private System.Windows.Forms.TextBox textRSpeed;
        private System.Windows.Forms.TextBox textRAcc;
        private System.Windows.Forms.Button SaveX;
        private System.Windows.Forms.Button SaveY;
        private System.Windows.Forms.Button SaveR;
        private System.Windows.Forms.Timer timerIO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textXMoveAbs;
        private System.Windows.Forms.TextBox textYMoveAbs;
        private System.Windows.Forms.TextBox textRMoveAbs;
        private System.Windows.Forms.Button btnXMoveAbs;
        private System.Windows.Forms.Button btnYMoveAbs;
        private System.Windows.Forms.Button btnRMoveAbs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ACSConnectLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button TCPConnect;
        private System.Windows.Forms.Button TCPDisConnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxCalinbrationY;
        private System.Windows.Forms.TextBox textBoxCalinbrationX;
        private System.Windows.Forms.Button buttonCalinbrationStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label CaliPoint1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label CaliPoint3;
        private System.Windows.Forms.Label CaliPoint2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label CaliPoint5;
        private System.Windows.Forms.Label CaliPoint4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label CaliPoint7;
        private System.Windows.Forms.Label CaliPoint6;
        private System.Windows.Forms.Label CaliPoint8;
        private System.Windows.Forms.Label CaliPoint9;
        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton D;
        private System.Windows.Forms.RadioButton A1;
        private System.Windows.Forms.RadioButton B1;
        private System.Windows.Forms.RadioButton C1;
        private System.Windows.Forms.RadioButton D1;
        private System.Windows.Forms.Panel panel1;
    }
}

