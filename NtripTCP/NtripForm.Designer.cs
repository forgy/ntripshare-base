// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports


namespace NtripClient
{
    [global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public
    partial class NtripForm : System.Windows.Forms.Form
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NtripForm));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbNtripCount = new System.Windows.Forms.Label();
            this.lbCorsCount = new System.Windows.Forms.Label();
            this.lbNtripStatus = new System.Windows.Forms.Label();
            this.lbCorsStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btStartServer = new System.Windows.Forms.Button();
            this.tbCasterPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbNtrip = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btDayConvert = new System.Windows.Forms.Button();
            this.btDayRinexBrow = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.tbRinexDaySavePath = new System.Windows.Forms.TextBox();
            this.cbDayRinex = new System.Windows.Forms.CheckBox();
            this.cbSaveDay = new System.Windows.Forms.CheckBox();
            this.btDayRtcmBrow = new System.Windows.Forms.Button();
            this.label56 = new System.Windows.Forms.Label();
            this.tbRtcmDaySavePath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btHourConvert = new System.Windows.Forms.Button();
            this.btHourRinexBrow = new System.Windows.Forms.Button();
            this.label63 = new System.Windows.Forms.Label();
            this.tbRinexHourSavePath = new System.Windows.Forms.TextBox();
            this.cbHourRinex = new System.Windows.Forms.CheckBox();
            this.cbSaveHour = new System.Windows.Forms.CheckBox();
            this.btHourRtcmBrow = new System.Windows.Forms.Button();
            this.label65 = new System.Windows.Forms.Label();
            this.tbRtcmHourSavePath = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.tbSiteName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCoord = new System.Windows.Forms.Button();
            this.checkBoxFloatCoord = new System.Windows.Forms.CheckBox();
            this.label50 = new System.Windows.Forms.Label();
            this.tbLon = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.tbLat = new System.Windows.Forms.TextBox();
            this.btGetMountPoints = new System.Windows.Forms.Button();
            this.cbMountPoints = new System.Windows.Forms.ComboBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rtbEvents = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvConnections = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvMountPoints = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btAddUser = new System.Windows.Forms.Button();
            this.btDelUser = new System.Windows.Forms.Button();
            this.btEditUser = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMountPoints)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.lbl3);
            this.splitContainer2.Panel1.Controls.Add(this.lbl2);
            this.splitContainer2.Panel1.Controls.Add(this.lblStatus);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rtbEvents);
            this.splitContainer2.Size = new System.Drawing.Size(828, 678);
            this.splitContainer2.SplitterDistance = 456;
            this.splitContainer2.TabIndex = 106;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbNtripCount);
            this.groupBox5.Controls.Add(this.lbCorsCount);
            this.groupBox5.Controls.Add(this.lbNtripStatus);
            this.groupBox5.Controls.Add(this.lbCorsStatus);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.btnClearLog);
            this.groupBox5.Controls.Add(this.btStartServer);
            this.groupBox5.Controls.Add(this.tbCasterPort);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.pbNtrip);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(32, 310);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(775, 138);
            this.groupBox5.TabIndex = 173;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "控制";
            // 
            // lbNtripCount
            // 
            this.lbNtripCount.AutoSize = true;
            this.lbNtripCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNtripCount.Location = new System.Drawing.Point(267, 118);
            this.lbNtripCount.Name = "lbNtripCount";
            this.lbNtripCount.Size = new System.Drawing.Size(11, 12);
            this.lbNtripCount.TabIndex = 194;
            this.lbNtripCount.Text = "0";
            // 
            // lbCorsCount
            // 
            this.lbCorsCount.AutoSize = true;
            this.lbCorsCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCorsCount.Location = new System.Drawing.Point(266, 93);
            this.lbCorsCount.Name = "lbCorsCount";
            this.lbCorsCount.Size = new System.Drawing.Size(11, 12);
            this.lbCorsCount.TabIndex = 193;
            this.lbCorsCount.Text = "0";
            // 
            // lbNtripStatus
            // 
            this.lbNtripStatus.AutoSize = true;
            this.lbNtripStatus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNtripStatus.Location = new System.Drawing.Point(90, 118);
            this.lbNtripStatus.Name = "lbNtripStatus";
            this.lbNtripStatus.Size = new System.Drawing.Size(41, 12);
            this.lbNtripStatus.TabIndex = 192;
            this.lbNtripStatus.Text = "未连接";
            // 
            // lbCorsStatus
            // 
            this.lbCorsStatus.AutoSize = true;
            this.lbCorsStatus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCorsStatus.Location = new System.Drawing.Point(89, 93);
            this.lbCorsStatus.Name = "lbCorsStatus";
            this.lbCorsStatus.Size = new System.Drawing.Size(41, 12);
            this.lbCorsStatus.TabIndex = 191;
            this.lbCorsStatus.Text = "未连接";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(184, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 190;
            this.label8.Text = "转发数据量：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(183, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 189;
            this.label9.Text = "CORS数据量：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(19, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 188;
            this.label7.Text = "转发状态：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 181;
            this.label1.Text = "CORS状态：";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(564, 96);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 30);
            this.button8.TabIndex = 187;
            this.button8.Text = "保存配置";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearLog.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearLog.Location = new System.Drawing.Point(674, 96);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(88, 30);
            this.btnClearLog.TabIndex = 182;
            this.btnClearLog.Text = "清除日志";
            this.btnClearLog.UseVisualStyleBackColor = false;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btStartServer
            // 
            this.btStartServer.BackColor = System.Drawing.SystemColors.Control;
            this.btStartServer.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btStartServer.Location = new System.Drawing.Point(604, 15);
            this.btStartServer.Name = "btStartServer";
            this.btStartServer.Size = new System.Drawing.Size(158, 30);
            this.btStartServer.TabIndex = 186;
            this.btStartServer.Text = "启动";
            this.btStartServer.UseVisualStyleBackColor = false;
            this.btStartServer.Click += new System.EventHandler(this.btStartServer_Click);
            // 
            // tbCasterPort
            // 
            this.tbCasterPort.Location = new System.Drawing.Point(114, 20);
            this.tbCasterPort.Name = "tbCasterPort";
            this.tbCasterPort.Size = new System.Drawing.Size(484, 21);
            this.tbCasterPort.TabIndex = 185;
            this.tbCasterPort.Text = "5000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 184;
            this.label3.Text = "SERVER端口:";
            // 
            // pbNtrip
            // 
            this.pbNtrip.Location = new System.Drawing.Point(21, 57);
            this.pbNtrip.Name = "pbNtrip";
            this.pbNtrip.Size = new System.Drawing.Size(741, 23);
            this.pbNtrip.TabIndex = 183;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label60);
            this.groupBox2.Controls.Add(this.tbSiteName);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(314, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 278);
            this.groupBox2.TabIndex = 173;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "保存原始数据";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btDayConvert);
            this.groupBox4.Controls.Add(this.btDayRinexBrow);
            this.groupBox4.Controls.Add(this.label54);
            this.groupBox4.Controls.Add(this.tbRinexDaySavePath);
            this.groupBox4.Controls.Add(this.cbDayRinex);
            this.groupBox4.Controls.Add(this.cbSaveDay);
            this.groupBox4.Controls.Add(this.btDayRtcmBrow);
            this.groupBox4.Controls.Add(this.label56);
            this.groupBox4.Controls.Add(this.tbRtcmDaySavePath);
            this.groupBox4.Location = new System.Drawing.Point(256, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 211);
            this.groupBox4.TabIndex = 174;
            this.groupBox4.TabStop = false;
            // 
            // btDayConvert
            // 
            this.btDayConvert.Location = new System.Drawing.Point(141, 121);
            this.btDayConvert.Name = "btDayConvert";
            this.btDayConvert.Size = new System.Drawing.Size(79, 23);
            this.btDayConvert.TabIndex = 45;
            this.btDayConvert.Text = "立即转换";
            this.btDayConvert.UseVisualStyleBackColor = true;
            this.btDayConvert.Click += new System.EventHandler(this.btDayConvert_Click);
            // 
            // btDayRinexBrow
            // 
            this.btDayRinexBrow.Location = new System.Drawing.Point(187, 169);
            this.btDayRinexBrow.Name = "btDayRinexBrow";
            this.btDayRinexBrow.Size = new System.Drawing.Size(33, 23);
            this.btDayRinexBrow.TabIndex = 56;
            this.btDayRinexBrow.Text = "...";
            this.btDayRinexBrow.UseVisualStyleBackColor = true;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(16, 151);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(65, 12);
            this.label54.TabIndex = 55;
            this.label54.Text = "保存路径：";
            // 
            // tbRinexDaySavePath
            // 
            this.tbRinexDaySavePath.Location = new System.Drawing.Point(16, 169);
            this.tbRinexDaySavePath.Name = "tbRinexDaySavePath";
            this.tbRinexDaySavePath.Size = new System.Drawing.Size(165, 21);
            this.tbRinexDaySavePath.TabIndex = 54;
            // 
            // cbDayRinex
            // 
            this.cbDayRinex.AutoSize = true;
            this.cbDayRinex.Location = new System.Drawing.Point(18, 126);
            this.cbDayRinex.Name = "cbDayRinex";
            this.cbDayRinex.Size = new System.Drawing.Size(90, 16);
            this.cbDayRinex.TabIndex = 53;
            this.cbDayRinex.Text = "转换到Rinex";
            this.cbDayRinex.UseVisualStyleBackColor = true;
            // 
            // cbSaveDay
            // 
            this.cbSaveDay.AutoSize = true;
            this.cbSaveDay.Location = new System.Drawing.Point(19, 35);
            this.cbSaveDay.Name = "cbSaveDay";
            this.cbSaveDay.Size = new System.Drawing.Size(96, 16);
            this.cbSaveDay.TabIndex = 50;
            this.cbSaveDay.Text = "按天保存数据";
            this.cbSaveDay.UseVisualStyleBackColor = true;
            // 
            // btDayRtcmBrow
            // 
            this.btDayRtcmBrow.Location = new System.Drawing.Point(188, 77);
            this.btDayRtcmBrow.Name = "btDayRtcmBrow";
            this.btDayRtcmBrow.Size = new System.Drawing.Size(33, 23);
            this.btDayRtcmBrow.TabIndex = 49;
            this.btDayRtcmBrow.Text = "...";
            this.btDayRtcmBrow.UseVisualStyleBackColor = true;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(17, 59);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(65, 12);
            this.label56.TabIndex = 47;
            this.label56.Text = "保存路径：";
            // 
            // tbRtcmDaySavePath
            // 
            this.tbRtcmDaySavePath.Location = new System.Drawing.Point(17, 77);
            this.tbRtcmDaySavePath.Name = "tbRtcmDaySavePath";
            this.tbRtcmDaySavePath.Size = new System.Drawing.Size(165, 21);
            this.tbRtcmDaySavePath.TabIndex = 46;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btHourConvert);
            this.groupBox3.Controls.Add(this.btHourRinexBrow);
            this.groupBox3.Controls.Add(this.label63);
            this.groupBox3.Controls.Add(this.tbRinexHourSavePath);
            this.groupBox3.Controls.Add(this.cbHourRinex);
            this.groupBox3.Controls.Add(this.cbSaveHour);
            this.groupBox3.Controls.Add(this.btHourRtcmBrow);
            this.groupBox3.Controls.Add(this.label65);
            this.groupBox3.Controls.Add(this.tbRtcmHourSavePath);
            this.groupBox3.Location = new System.Drawing.Point(17, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 211);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            // 
            // btHourConvert
            // 
            this.btHourConvert.Location = new System.Drawing.Point(133, 122);
            this.btHourConvert.Name = "btHourConvert";
            this.btHourConvert.Size = new System.Drawing.Size(80, 23);
            this.btHourConvert.TabIndex = 17;
            this.btHourConvert.Text = "立即转换";
            this.btHourConvert.UseVisualStyleBackColor = true;
            this.btHourConvert.Click += new System.EventHandler(this.btHourConvert_Click);
            // 
            // btHourRinexBrow
            // 
            this.btHourRinexBrow.Location = new System.Drawing.Point(180, 169);
            this.btHourRinexBrow.Name = "btHourRinexBrow";
            this.btHourRinexBrow.Size = new System.Drawing.Size(33, 23);
            this.btHourRinexBrow.TabIndex = 44;
            this.btHourRinexBrow.Text = "...";
            this.btHourRinexBrow.UseVisualStyleBackColor = true;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(14, 151);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(65, 12);
            this.label63.TabIndex = 43;
            this.label63.Text = "保存路径：";
            // 
            // tbRinexHourSavePath
            // 
            this.tbRinexHourSavePath.Location = new System.Drawing.Point(14, 169);
            this.tbRinexHourSavePath.Name = "tbRinexHourSavePath";
            this.tbRinexHourSavePath.Size = new System.Drawing.Size(160, 21);
            this.tbRinexHourSavePath.TabIndex = 42;
            // 
            // cbHourRinex
            // 
            this.cbHourRinex.AutoSize = true;
            this.cbHourRinex.Location = new System.Drawing.Point(16, 126);
            this.cbHourRinex.Name = "cbHourRinex";
            this.cbHourRinex.Size = new System.Drawing.Size(90, 16);
            this.cbHourRinex.TabIndex = 41;
            this.cbHourRinex.Text = "转换到Rinex";
            this.cbHourRinex.UseVisualStyleBackColor = true;
            // 
            // cbSaveHour
            // 
            this.cbSaveHour.AutoSize = true;
            this.cbSaveHour.Location = new System.Drawing.Point(16, 34);
            this.cbSaveHour.Name = "cbSaveHour";
            this.cbSaveHour.Size = new System.Drawing.Size(108, 16);
            this.cbSaveHour.TabIndex = 38;
            this.cbSaveHour.Text = "按小时保存数据";
            this.cbSaveHour.UseVisualStyleBackColor = true;
            // 
            // btHourRtcmBrow
            // 
            this.btHourRtcmBrow.Location = new System.Drawing.Point(180, 76);
            this.btHourRtcmBrow.Name = "btHourRtcmBrow";
            this.btHourRtcmBrow.Size = new System.Drawing.Size(33, 23);
            this.btHourRtcmBrow.TabIndex = 37;
            this.btHourRtcmBrow.Text = "...";
            this.btHourRtcmBrow.UseVisualStyleBackColor = true;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(14, 58);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(65, 12);
            this.label65.TabIndex = 35;
            this.label65.Text = "保存路径：";
            // 
            // tbRtcmHourSavePath
            // 
            this.tbRtcmHourSavePath.Location = new System.Drawing.Point(14, 76);
            this.tbRtcmHourSavePath.Name = "tbRtcmHourSavePath";
            this.tbRtcmHourSavePath.Size = new System.Drawing.Size(160, 21);
            this.tbRtcmHourSavePath.TabIndex = 34;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(25, 30);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(41, 12);
            this.label60.TabIndex = 1;
            this.label60.Text = "点名：";
            // 
            // tbSiteName
            // 
            this.tbSiteName.Location = new System.Drawing.Point(70, 27);
            this.tbSiteName.Name = "tbSiteName";
            this.tbSiteName.Size = new System.Drawing.Size(417, 21);
            this.tbSiteName.TabIndex = 0;
            this.tbSiteName.Text = "cors";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCoord);
            this.groupBox1.Controls.Add(this.checkBoxFloatCoord);
            this.groupBox1.Controls.Add(this.label50);
            this.groupBox1.Controls.Add(this.tbLon);
            this.groupBox1.Controls.Add(this.label51);
            this.groupBox1.Controls.Add(this.tbLat);
            this.groupBox1.Controls.Add(this.btGetMountPoints);
            this.groupBox1.Controls.Add(this.cbMountPoints);
            this.groupBox1.Controls.Add(this.label49);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label48);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.label45);
            this.groupBox1.Controls.Add(this.tbIP);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(32, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 278);
            this.groupBox1.TabIndex = 172;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CORS设置";
            // 
            // buttonCoord
            // 
            this.buttonCoord.Enabled = false;
            this.buttonCoord.Location = new System.Drawing.Point(141, 227);
            this.buttonCoord.Name = "buttonCoord";
            this.buttonCoord.Size = new System.Drawing.Size(101, 23);
            this.buttonCoord.TabIndex = 18;
            this.buttonCoord.Text = "地图选择坐标";
            this.buttonCoord.UseVisualStyleBackColor = true;
            this.buttonCoord.Click += new System.EventHandler(this.buttonCoord_Click);
            // 
            // checkBoxFloatCoord
            // 
            this.checkBoxFloatCoord.AutoSize = true;
            this.checkBoxFloatCoord.Location = new System.Drawing.Point(25, 234);
            this.checkBoxFloatCoord.Name = "checkBoxFloatCoord";
            this.checkBoxFloatCoord.Size = new System.Drawing.Size(108, 16);
            this.checkBoxFloatCoord.TabIndex = 17;
            this.checkBoxFloatCoord.Text = "采用流动站坐标";
            this.checkBoxFloatCoord.UseVisualStyleBackColor = true;
            this.checkBoxFloatCoord.CheckedChanged += new System.EventHandler(this.checkBoxFloatCoord_CheckedChanged);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(141, 175);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(119, 12);
            this.label50.TabIndex = 14;
            this.label50.Text = "经度（DDD.MMSSSSS）";
            // 
            // tbLon
            // 
            this.tbLon.Location = new System.Drawing.Point(141, 193);
            this.tbLon.Name = "tbLon";
            this.tbLon.Size = new System.Drawing.Size(100, 21);
            this.tbLon.TabIndex = 13;
            this.tbLon.Text = "114.253021431";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(24, 175);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(113, 12);
            this.label51.TabIndex = 12;
            this.label51.Text = "纬度（DD.MMSSSSS）";
            // 
            // tbLat
            // 
            this.tbLat.Location = new System.Drawing.Point(24, 193);
            this.tbLat.Name = "tbLat";
            this.tbLat.Size = new System.Drawing.Size(100, 21);
            this.tbLat.TabIndex = 11;
            this.tbLat.Text = "23.032321341";
            // 
            // btGetMountPoints
            // 
            this.btGetMountPoints.Location = new System.Drawing.Point(195, 137);
            this.btGetMountPoints.Name = "btGetMountPoints";
            this.btGetMountPoints.Size = new System.Drawing.Size(46, 23);
            this.btGetMountPoints.TabIndex = 10;
            this.btGetMountPoints.Text = "获取";
            this.btGetMountPoints.UseVisualStyleBackColor = true;
            this.btGetMountPoints.Click += new System.EventHandler(this.btGetMountPoints_Click);
            // 
            // cbMountPoints
            // 
            this.cbMountPoints.FormattingEnabled = true;
            this.cbMountPoints.Location = new System.Drawing.Point(25, 139);
            this.cbMountPoints.Name = "cbMountPoints";
            this.cbMountPoints.Size = new System.Drawing.Size(164, 20);
            this.cbMountPoints.TabIndex = 9;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(25, 122);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(41, 12);
            this.label49.TabIndex = 8;
            this.label49.Text = "接入点";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(142, 74);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(29, 12);
            this.label47.TabIndex = 7;
            this.label47.Text = "密码";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(142, 92);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 21);
            this.tbPassword.TabIndex = 6;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(25, 74);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(41, 12);
            this.label48.TabIndex = 5;
            this.label48.Text = "用户名";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(25, 92);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 21);
            this.tbUsername.TabIndex = 4;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(142, 21);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(29, 12);
            this.label46.TabIndex = 3;
            this.label46.Text = "端口";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(142, 39);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 21);
            this.tbPort.TabIndex = 2;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(25, 21);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(17, 12);
            this.label45.TabIndex = 1;
            this.label45.Text = "IP";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(25, 39);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 21);
            this.tbIP.TabIndex = 0;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(417, -26);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 26);
            this.lbl3.TabIndex = 96;
            this.lbl3.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(215, -26);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 26);
            this.lbl2.TabIndex = 94;
            this.lbl2.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(13, -26);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(157, 26);
            this.lblStatus.TabIndex = 93;
            this.lblStatus.Text = "Not Connected";
            this.lblStatus.Visible = false;
            // 
            // rtbEvents
            // 
            this.rtbEvents.BackColor = System.Drawing.SystemColors.Control;
            this.rtbEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEvents.ForeColor = System.Drawing.Color.Black;
            this.rtbEvents.Location = new System.Drawing.Point(0, 0);
            this.rtbEvents.Name = "rtbEvents";
            this.rtbEvents.ReadOnly = true;
            this.rtbEvents.Size = new System.Drawing.Size(826, 216);
            this.rtbEvents.TabIndex = 95;
            this.rtbEvents.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 711);
            this.tabControl1.TabIndex = 80;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(834, 684);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvConnections);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(834, 684);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "连接";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvConnections
            // 
            this.dgvConnections.AllowUserToAddRows = false;
            this.dgvConnections.AllowUserToDeleteRows = false;
            this.dgvConnections.AllowUserToResizeRows = false;
            this.dgvConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConnections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConnections.Location = new System.Drawing.Point(3, 3);
            this.dgvConnections.MultiSelect = false;
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.ReadOnly = true;
            this.dgvConnections.RowHeadersVisible = false;
            this.dgvConnections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConnections.ShowEditingIcon = false;
            this.dgvConnections.Size = new System.Drawing.Size(828, 678);
            this.dgvConnections.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvMountPoints);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(834, 684);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "接入点";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvMountPoints
            // 
            this.dgvMountPoints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMountPoints.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMountPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMountPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMountPoints.Location = new System.Drawing.Point(0, 0);
            this.dgvMountPoints.MultiSelect = false;
            this.dgvMountPoints.Name = "dgvMountPoints";
            this.dgvMountPoints.RowHeadersWidth = 20;
            this.dgvMountPoints.Size = new System.Drawing.Size(834, 684);
            this.dgvMountPoints.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(834, 684);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "用户";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvUsers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btAddUser);
            this.splitContainer1.Panel2.Controls.Add(this.btDelUser);
            this.splitContainer1.Panel2.Controls.Add(this.btEditUser);
            this.splitContainer1.Size = new System.Drawing.Size(834, 684);
            this.splitContainer1.SplitterDistance = 632;
            this.splitContainer1.TabIndex = 13;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 20;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(834, 632);
            this.dgvUsers.TabIndex = 7;
            // 
            // btAddUser
            // 
            this.btAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddUser.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddUser.Location = new System.Drawing.Point(635, 13);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(60, 25);
            this.btAddUser.TabIndex = 12;
            this.btAddUser.Text = "添加";
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // btDelUser
            // 
            this.btDelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelUser.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelUser.Location = new System.Drawing.Point(701, 12);
            this.btDelUser.Name = "btDelUser";
            this.btDelUser.Size = new System.Drawing.Size(61, 25);
            this.btDelUser.TabIndex = 11;
            this.btDelUser.Text = "删除";
            this.btDelUser.UseVisualStyleBackColor = true;
            this.btDelUser.Click += new System.EventHandler(this.btDelUser_Click);
            // 
            // btEditUser
            // 
            this.btEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditUser.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEditUser.Location = new System.Drawing.Point(768, 12);
            this.btEditUser.Name = "btEditUser";
            this.btEditUser.Size = new System.Drawing.Size(58, 25);
            this.btEditUser.TabIndex = 10;
            this.btEditUser.Text = "编辑";
            this.btEditUser.UseVisualStyleBackColor = true;
            this.btEditUser.Click += new System.EventHandler(this.btEditUser_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.pictureBox1);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.lblVersion);
            this.tabPage6.Location = new System.Drawing.Point(4, 23);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(834, 684);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "关于";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "请在法律允许范围内使用，作者不承担任何法律责任";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 426);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "QQ:273066127";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "NtripShare Base 2020 ";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(364, 108);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(89, 20);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "Version:1.0";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusBar});
            this.StatusStrip.Location = new System.Drawing.Point(0, 711);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(842, 22);
            this.StatusStrip.TabIndex = 81;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(96, 17);
            this.lblStatusBar.Text = "Not Connected";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // NtripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(842, 733);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.StatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NtripForm";
            this.Text = "NtripShare Base By Mr.Peng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMountPoints)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.Timer Timer1;
        private System.ComponentModel.IContainer components;
        private SplitContainer splitContainer2;
        internal RichTextBox rtbEvents;
        internal Label lbl3;
        internal Label lbl2;
        internal Label lblStatus;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage6;
        internal DataGridView dgvConnections;
        internal DataGridView dgvMountPoints;
        internal Label label4;
        internal Label lblVersion;
        internal DataGridView dgvUsers;
        internal StatusStrip StatusStrip;
        internal ToolStripStatusLabel lblStatusBar;
        internal Label label5;
        private Button btAddUser;
        internal Button btDelUser;
        internal Button btEditUser;
        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Button btDayRinexBrow;
        private Label label54;
        private TextBox tbRinexDaySavePath;
        private CheckBox cbDayRinex;
        private CheckBox cbSaveDay;
        private Button btDayRtcmBrow;
        private Label label56;
        private TextBox tbRtcmDaySavePath;
        private GroupBox groupBox3;
        private Button btHourRinexBrow;
        private Label label63;
        private TextBox tbRinexHourSavePath;
        private CheckBox cbHourRinex;
        private CheckBox cbSaveHour;
        private Button btHourRtcmBrow;
        private Label label65;
        private TextBox tbRtcmHourSavePath;
        private Label label60;
        private TextBox tbSiteName;
        private GroupBox groupBox1;
        private Label label50;
        private TextBox tbLon;
        private Label label51;
        private TextBox tbLat;
        private Button btGetMountPoints;
        private ComboBox cbMountPoints;
        private Label label49;
        private Label label47;
        private TextBox tbPassword;
        private Label label48;
        private TextBox tbUsername;
        private Label label46;
        private TextBox tbPort;
        private Label label45;
        private TextBox tbIP;
        private Button btDayConvert;
        private Button btHourConvert;
        private GroupBox groupBox5;
        private Label lbNtripCount;
        private Label lbCorsCount;
        private Label lbNtripStatus;
        private Label lbCorsStatus;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label1;
        internal Button button8;
        internal Button btnClearLog;
        internal Button btStartServer;
        private TextBox tbCasterPort;
        internal Label label3;
        private ProgressBar pbNtrip;
        internal Timer timer2;
        private PictureBox pictureBox1;
        internal Label label6;
        private Button buttonCoord;
        private CheckBox checkBoxFloatCoord;
    }

}
