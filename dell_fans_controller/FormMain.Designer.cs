namespace dell_fans_controller
{
    partial class frmMain
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
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnVisitDellService = new System.Windows.Forms.Button();
            this.lblIp = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.trkBarSpeed = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.nbrUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.lnkRepo = new System.Windows.Forms.LinkLabel();
            this.lnkMyWebsite = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lstViewSensor = new System.Windows.Forms.ListView();
            this.colKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFaultThresholdMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWarningThresholdMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWarningThresholdMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFaultThresholdMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExtra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefreshNow = new System.Windows.Forms.Button();
            this.demo = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrUpDownSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.lblPassword);
            this.grpMain.Controls.Add(this.txtPassword);
            this.grpMain.Controls.Add(this.lblUser);
            this.grpMain.Controls.Add(this.txtUser);
            this.grpMain.Controls.Add(this.btnVisitDellService);
            this.grpMain.Controls.Add(this.lblIp);
            this.grpMain.Controls.Add(this.txtIp);
            this.grpMain.Controls.Add(this.trkBarSpeed);
            this.grpMain.Controls.Add(this.btnReset);
            this.grpMain.Controls.Add(this.btnSet);
            this.grpMain.Controls.Add(this.nbrUpDownSpeed);
            this.grpMain.Location = new System.Drawing.Point(16, 15);
            this.grpMain.Margin = new System.Windows.Forms.Padding(4);
            this.grpMain.Name = "grpMain";
            this.grpMain.Padding = new System.Windows.Forms.Padding(4);
            this.grpMain.Size = new System.Drawing.Size(786, 279);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Fans Speed Control";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(443, 46);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 15);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(521, 42);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(132, 25);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "root";
            this.txtPassword.LostFocus += new System.EventHandler(this.TxtPassword_LostFocus);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(229, 46);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(39, 15);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(276, 42);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(132, 25);
            this.txtUser.TabIndex = 8;
            this.txtUser.Text = "root";
            this.txtUser.LostFocus += new System.EventHandler(this.TxtUser_LostFocus);
            // 
            // btnVisitDellService
            // 
            this.btnVisitDellService.Location = new System.Drawing.Point(63, 86);
            this.btnVisitDellService.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisitDellService.Name = "btnVisitDellService";
            this.btnVisitDellService.Size = new System.Drawing.Size(277, 47);
            this.btnVisitDellService.TabIndex = 7;
            this.btnVisitDellService.Text = "iDRAC页面";
            this.btnVisitDellService.UseVisualStyleBackColor = true;
            this.btnVisitDellService.Click += new System.EventHandler(this.btnVisitDellService_Click);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(20, 46);
            this.lblIp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(23, 15);
            this.lblIp.TabIndex = 6;
            this.lblIp.Text = "IP";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(63, 42);
            this.txtIp.Margin = new System.Windows.Forms.Padding(4);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(132, 25);
            this.txtIp.TabIndex = 5;
            this.txtIp.Text = "192.168.0.1";
            this.txtIp.LostFocus += new System.EventHandler(this.TxtIp_LostFocus);
            // 
            // trkBarSpeed
            // 
            this.trkBarSpeed.Location = new System.Drawing.Point(23, 145);
            this.trkBarSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.trkBarSpeed.Maximum = 100;
            this.trkBarSpeed.Name = "trkBarSpeed";
            this.trkBarSpeed.Size = new System.Drawing.Size(640, 56);
            this.trkBarSpeed.TabIndex = 4;
            this.trkBarSpeed.Scroll += new System.EventHandler(this.trkBarSpeed_Scroll);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(342, 213);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(267, 50);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "恢复默认设置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(39, 213);
            this.btnSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(267, 50);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "转速设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // nbrUpDownSpeed
            // 
            this.nbrUpDownSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nbrUpDownSpeed.Location = new System.Drawing.Point(671, 145);
            this.nbrUpDownSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.nbrUpDownSpeed.Name = "nbrUpDownSpeed";
            this.nbrUpDownSpeed.Size = new System.Drawing.Size(67, 25);
            this.nbrUpDownSpeed.TabIndex = 1;
            this.nbrUpDownSpeed.ValueChanged += new System.EventHandler(this.nbrUpDownSpeed_ValueChanged);
            // 
            // lnkRepo
            // 
            this.lnkRepo.AutoSize = true;
            this.lnkRepo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkRepo.Location = new System.Drawing.Point(13, 800);
            this.lnkRepo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkRepo.Name = "lnkRepo";
            this.lnkRepo.Size = new System.Drawing.Size(375, 15);
            this.lnkRepo.TabIndex = 3;
            this.lnkRepo.TabStop = true;
            this.lnkRepo.Text = "https://github.com/cw1997/dell_fans_controller";
            this.lnkRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRepo_LinkClicked);
            // 
            // lnkMyWebsite
            // 
            this.lnkMyWebsite.AutoSize = true;
            this.lnkMyWebsite.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMyWebsite.Location = new System.Drawing.Point(532, 800);
            this.lnkMyWebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkMyWebsite.Name = "lnkMyWebsite";
            this.lnkMyWebsite.Size = new System.Drawing.Size(151, 15);
            this.lnkMyWebsite.TabIndex = 5;
            this.lnkMyWebsite.TabStop = true;
            this.lnkMyWebsite.Text = "http://changwei.me";
            this.lnkMyWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMyWebsite_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 800);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Code By cw1997";
            // 
            // lstViewSensor
            // 
            this.lstViewSensor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colKey,
            this.colValue,
            this.colUnit,
            this.colStatus,
            this.colFaultThresholdMin,
            this.colWarningThresholdMin,
            this.colWarningThresholdMax,
            this.colFaultThresholdMax,
            this.colExtra});
            this.lstViewSensor.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstViewSensor.FullRowSelect = true;
            this.lstViewSensor.GridLines = true;
            this.lstViewSensor.HideSelection = false;
            this.lstViewSensor.LabelEdit = true;
            this.lstViewSensor.Location = new System.Drawing.Point(16, 394);
            this.lstViewSensor.Margin = new System.Windows.Forms.Padding(4);
            this.lstViewSensor.Name = "lstViewSensor";
            this.lstViewSensor.Size = new System.Drawing.Size(1292, 348);
            this.lstViewSensor.TabIndex = 7;
            this.lstViewSensor.UseCompatibleStateImageBehavior = false;
            this.lstViewSensor.View = System.Windows.Forms.View.Details;
            // 
            // colKey
            // 
            this.colKey.Text = "Key";
            this.colKey.Width = 200;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 100;
            // 
            // colUnit
            // 
            this.colUnit.Text = "Unit";
            this.colUnit.Width = 100;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 100;
            // 
            // colFaultThresholdMin
            // 
            this.colFaultThresholdMin.Text = "FaultThresholdMin";
            this.colFaultThresholdMin.Width = 100;
            // 
            // colWarningThresholdMin
            // 
            this.colWarningThresholdMin.Text = "WarningThresholdMin";
            this.colWarningThresholdMin.Width = 100;
            // 
            // colWarningThresholdMax
            // 
            this.colWarningThresholdMax.Text = "WarningThresholdMax";
            this.colWarningThresholdMax.Width = 100;
            // 
            // colFaultThresholdMax
            // 
            this.colFaultThresholdMax.Text = "FaultThresholdMax";
            this.colFaultThresholdMax.Width = 100;
            // 
            // colExtra
            // 
            this.colExtra.Text = "Extra";
            // 
            // btnRefreshNow
            // 
            this.btnRefreshNow.Location = new System.Drawing.Point(21, 318);
            this.btnRefreshNow.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshNow.Name = "btnRefreshNow";
            this.btnRefreshNow.Size = new System.Drawing.Size(210, 32);
            this.btnRefreshNow.TabIndex = 12;
            this.btnRefreshNow.Text = "传感器刷新";
            this.btnRefreshNow.UseVisualStyleBackColor = true;
            this.btnRefreshNow.Click += new System.EventHandler(this.btnRefreshNow_Click);
            // 
            // demo
            // 
            this.demo.Location = new System.Drawing.Point(260, 318);
            this.demo.Name = "demo";
            this.demo.Size = new System.Drawing.Size(210, 32);
            this.demo.TabIndex = 12;
            this.demo.Text = "硬件状态";
            this.demo.UseVisualStyleBackColor = true;
            this.demo.Click += new System.EventHandler(this.button1_Click);
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.Red;
            this.up.ForeColor = System.Drawing.Color.Yellow;
            this.up.Location = new System.Drawing.Point(43, 53);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(75, 47);
            this.up.TabIndex = 14;
            this.up.Text = "开机";
            this.up.UseVisualStyleBackColor = false;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.up);
            this.groupBox1.Location = new System.Drawing.Point(831, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 267);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(537, 326);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 19);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "风扇,温度,电流";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(732, 326);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(129, 19);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "自动刷新(20S)";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 823);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.demo);
            this.Controls.Add(this.btnRefreshNow);
            this.Controls.Add(this.lstViewSensor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkMyWebsite);
            this.Controls.Add(this.lnkRepo);
            this.Controls.Add(this.grpMain);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Dell Fans Speed Controller";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrUpDownSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.TrackBar trkBarSpeed;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.NumericUpDown nbrUpDownSpeed;
        private System.Windows.Forms.LinkLabel lnkRepo;
        private System.Windows.Forms.LinkLabel lnkMyWebsite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVisitDellService;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ListView lstViewSensor;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.ColumnHeader colUnit;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colFaultThresholdMin;
        private System.Windows.Forms.ColumnHeader colWarningThresholdMin;
        private System.Windows.Forms.ColumnHeader colWarningThresholdMax;
        private System.Windows.Forms.ColumnHeader colFaultThresholdMax;
        private System.Windows.Forms.ColumnHeader colExtra;
        private System.Windows.Forms.Button btnRefreshNow;
        private System.Windows.Forms.ColumnHeader colKey;
        private System.Windows.Forms.Button demo;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Timer timer2;
    }
}

