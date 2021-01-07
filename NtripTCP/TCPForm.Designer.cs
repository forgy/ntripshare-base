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


namespace NTRIPClient
{
    [global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public
    partial class TCPForm : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TCPForm));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.cbFormat8 = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.tbPointName8 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txServerPort8 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.bt8 = new System.Windows.Forms.Button();
            this.cbFormat7 = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.tbPointName7 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txServerPort7 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.bt7 = new System.Windows.Forms.Button();
            this.cbFormat6 = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.tbPointName6 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txServerPort6 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.bt6 = new System.Windows.Forms.Button();
            this.cbFormat5 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbPointName5 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txServerPort5 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.bt5 = new System.Windows.Forms.Button();
            this.cbFormat4 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbPointName4 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txServerPort4 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.bt4 = new System.Windows.Forms.Button();
            this.cbFormat3 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbPointName3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txServerPort3 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.bt3 = new System.Windows.Forms.Button();
            this.cbFormat2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPointName2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txServerPort2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bt2 = new System.Windows.Forms.Button();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPointName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btStartServer = new System.Windows.Forms.Button();
            this.tbCasterPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTCPStatus = new System.Windows.Forms.Label();
            this.pbTCP = new System.Windows.Forms.ProgressBar();
            this.txServerPort = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
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
            this.Label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timerDog = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.splitContainer2.Panel1.Controls.Add(this.labelStartTime);
            this.splitContainer2.Panel1.Controls.Add(this.textBox8);
            this.splitContainer2.Panel1.Controls.Add(this.textBox7);
            this.splitContainer2.Panel1.Controls.Add(this.textBox6);
            this.splitContainer2.Panel1.Controls.Add(this.textBox5);
            this.splitContainer2.Panel1.Controls.Add(this.textBox4);
            this.splitContainer2.Panel1.Controls.Add(this.textBox3);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.button8);
            this.splitContainer2.Panel1.Controls.Add(this.btnClearLog);
            this.splitContainer2.Panel1.Controls.Add(this.cbFormat8);
            this.splitContainer2.Panel1.Controls.Add(this.label40);
            this.splitContainer2.Panel1.Controls.Add(this.label41);
            this.splitContainer2.Panel1.Controls.Add(this.tbPointName8);
            this.splitContainer2.Panel1.Controls.Add(this.label42);
            this.splitContainer2.Panel1.Controls.Add(this.label43);
            this.splitContainer2.Panel1.Controls.Add(this.txServerPort8);
            this.splitContainer2.Panel1.Controls.Add(this.label44);
            this.splitContainer2.Panel1.Controls.Add(this.bt8);
            this.splitContainer2.Panel1.Controls.Add(this.cbFormat7);
            this.splitContainer2.Panel1.Controls.Add(this.label35);
            this.splitContainer2.Panel1.Controls.Add(this.label36);
            this.splitContainer2.Panel1.Controls.Add(this.tbPointName7);
            this.splitContainer2.Panel1.Controls.Add(this.label37);
            this.splitContainer2.Panel1.Controls.Add(this.label38);
            this.splitContainer2.Panel1.Controls.Add(this.txServerPort7);
            this.splitContainer2.Panel1.Controls.Add(this.label39);
            this.splitContainer2.Panel1.Controls.Add(this.bt7);
            this.splitContainer2.Panel1.Controls.Add(this.cbFormat6);
            this.splitContainer2.Panel1.Controls.Add(this.label30);
            this.splitContainer2.Panel1.Controls.Add(this.label31);
            this.splitContainer2.Panel1.Controls.Add(this.tbPointName6);
            this.splitContainer2.Panel1.Controls.Add(this.label32);
            this.splitContainer2.Panel1.Controls.Add(this.label33);
            this.splitContainer2.Panel1.Controls.Add(this.txServerPort6);
            this.splitContainer2.Panel1.Controls.Add(this.label34);
            this.splitContainer2.Panel1.Controls.Add(this.bt6);
            this.splitContainer2.Panel1.Controls.Add(this.cbFormat5);
            this.splitContainer2.Panel1.Controls.Add(this.label25);
            this.splitContainer2.Panel1.Controls.Add(this.label26);
            this.splitContainer2.Panel1.Controls.Add(this.tbPointName5);
            this.splitContainer2.Panel1.Controls.Add(this.label27);
            this.splitContainer2.Panel1.Controls.Add(this.label28);
            this.splitContainer2.Panel1.Controls.Add(this.txServerPort5);
            this.splitContainer2.Panel1.Controls.Add(this.label29);
            this.splitContainer2.Panel1.Controls.Add(this.bt5);
            this.splitContainer2.Panel1.Controls.Add(this.cbFormat4);
            this.splitContainer2.Panel1.Controls.Add(this.label20);
            this.splitContainer2.Panel1.Controls.Add(this.label21);
            this.splitContainer2.Panel1.Controls.Add(this.tbPointName4);
            this.splitContainer2.Panel1.Controls.Add(this.label22);
            this.splitContainer2.Panel1.Controls.Add(this.label23);
            this.splitContainer2.Panel1.Controls.Add(this.txServerPort4);
            this.splitContainer2.Panel1.Controls.Add(this.label24);
            this.splitContainer2.Panel1.Controls.Add(this.bt4);
            this.splitContainer2.Panel1.Controls.Add(this.cbFormat3);
            this.splitContainer2.Panel1.Controls.Add(this.label15);
            this.splitContainer2.Panel1.Controls.Add(this.label16);
            this.splitContainer2.Panel1.Controls.Add(this.tbPointName3);
            this.splitContainer2.Panel1.Controls.Add(this.label17);
            this.splitContainer2.Panel1.Controls.Add(this.label18);
            this.splitContainer2.Panel1.Controls.Add(this.txServerPort3);
            this.splitContainer2.Panel1.Controls.Add(this.label19);
            this.splitContainer2.Panel1.Controls.Add(this.bt3);
            this.splitContainer2.Panel1.Controls.Add(this.cbFormat2);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.tbPointName2);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.txServerPort2);
            this.splitContainer2.Panel1.Controls.Add(this.label14);
            this.splitContainer2.Panel1.Controls.Add(this.bt2);
            this.splitContainer2.Panel1.Controls.Add(this.cbFormat);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.tbPointName);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.btStartServer);
            this.splitContainer2.Panel1.Controls.Add(this.tbCasterPort);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.lbTCPStatus);
            this.splitContainer2.Panel1.Controls.Add(this.pbTCP);
            this.splitContainer2.Panel1.Controls.Add(this.txServerPort);
            this.splitContainer2.Panel1.Controls.Add(this.Label1);
            this.splitContainer2.Panel1.Controls.Add(this.lbl3);
            this.splitContainer2.Panel1.Controls.Add(this.lbl2);
            this.splitContainer2.Panel1.Controls.Add(this.lblStatus);
            this.splitContainer2.Panel1.Controls.Add(this.bt1);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rtbEvents);
            this.splitContainer2.Size = new System.Drawing.Size(803, 686);
            this.splitContainer2.SplitterDistance = 450;
            this.splitContainer2.TabIndex = 106;
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStartTime.Location = new System.Drawing.Point(45, 418);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(52, 14);
            this.labelStartTime.TabIndex = 180;
            this.labelStartTime.Text = "未启动";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox8.ForeColor = System.Drawing.Color.Green;
            this.textBox8.Location = new System.Drawing.Point(602, 286);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 23);
            this.textBox8.TabIndex = 179;
            this.textBox8.Tag = "12-RTCM39";
            this.textBox8.Text = "0";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7.ForeColor = System.Drawing.Color.Green;
            this.textBox7.Location = new System.Drawing.Point(602, 246);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 178;
            this.textBox7.Tag = "12-RTCM38";
            this.textBox7.Text = "0";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.ForeColor = System.Drawing.Color.Green;
            this.textBox6.Location = new System.Drawing.Point(602, 209);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 177;
            this.textBox6.Tag = "12-RTCM37";
            this.textBox6.Text = "0";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.ForeColor = System.Drawing.Color.Green;
            this.textBox5.Location = new System.Drawing.Point(602, 174);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 176;
            this.textBox5.Tag = "12-RTCM36";
            this.textBox5.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.ForeColor = System.Drawing.Color.Green;
            this.textBox4.Location = new System.Drawing.Point(602, 136);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 175;
            this.textBox4.Tag = "12-RTCM35";
            this.textBox4.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.ForeColor = System.Drawing.Color.Green;
            this.textBox3.Location = new System.Drawing.Point(602, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 174;
            this.textBox3.Tag = "12-RTCM34";
            this.textBox3.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.ForeColor = System.Drawing.Color.Green;
            this.textBox2.Location = new System.Drawing.Point(602, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 173;
            this.textBox2.Tag = "12-RTCM33";
            this.textBox2.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.Green;
            this.textBox1.Location = new System.Drawing.Point(602, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 172;
            this.textBox1.Tag = "12-RTCM32";
            this.textBox1.Text = "0";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(591, 409);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 30);
            this.button8.TabIndex = 171;
            this.button8.Text = "保存";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearLog.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLog.Location = new System.Drawing.Point(679, 409);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(82, 30);
            this.btnClearLog.TabIndex = 98;
            this.btnClearLog.Text = "清除";
            this.btnClearLog.UseVisualStyleBackColor = false;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // cbFormat8
            // 
            this.cbFormat8.FormattingEnabled = true;
            this.cbFormat8.Items.AddRange(new object[] {
            "RTCM30",
            "RTCM32"});
            this.cbFormat8.Location = new System.Drawing.Point(486, 287);
            this.cbFormat8.Name = "cbFormat8";
            this.cbFormat8.Size = new System.Drawing.Size(102, 21);
            this.cbFormat8.TabIndex = 170;
            this.cbFormat8.Text = "RTCM32";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.SystemColors.Control;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(411, 289);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(68, 17);
            this.label40.TabIndex = 169;
            this.label40.Text = "数据格式:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(527, 292);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(0, 14);
            this.label41.TabIndex = 168;
            this.label41.Visible = false;
            // 
            // tbPointName8
            // 
            this.tbPointName8.Location = new System.Drawing.Point(305, 287);
            this.tbPointName8.Name = "tbPointName8";
            this.tbPointName8.Size = new System.Drawing.Size(95, 23);
            this.tbPointName8.TabIndex = 167;
            this.tbPointName8.Text = "12-RTCM39";
            this.tbPointName8.TextChanged += new System.EventHandler(this.tbPointName8_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.SystemColors.Control;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Location = new System.Drawing.Point(259, 289);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(40, 17);
            this.label42.TabIndex = 166;
            this.label42.Text = "名称:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(361, 291);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(0, 14);
            this.label43.TabIndex = 165;
            this.label43.Visible = false;
            // 
            // txServerPort8
            // 
            this.txServerPort8.Location = new System.Drawing.Point(148, 286);
            this.txServerPort8.Name = "txServerPort8";
            this.txServerPort8.Size = new System.Drawing.Size(95, 23);
            this.txServerPort8.TabIndex = 164;
            this.txServerPort8.Text = "6068";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.SystemColors.Control;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Location = new System.Drawing.Point(52, 287);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(75, 17);
            this.label44.TabIndex = 162;
            this.label44.Text = "TCP端口8:";
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.SystemColors.Control;
            this.bt8.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(708, 282);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(51, 30);
            this.bt8.TabIndex = 163;
            this.bt8.Text = "启动";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // cbFormat7
            // 
            this.cbFormat7.FormattingEnabled = true;
            this.cbFormat7.Items.AddRange(new object[] {
            "RTCM30",
            "RTCM32"});
            this.cbFormat7.Location = new System.Drawing.Point(486, 248);
            this.cbFormat7.Name = "cbFormat7";
            this.cbFormat7.Size = new System.Drawing.Size(102, 21);
            this.cbFormat7.TabIndex = 161;
            this.cbFormat7.Text = "RTCM32";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.SystemColors.Control;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(411, 250);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(68, 17);
            this.label35.TabIndex = 160;
            this.label35.Text = "数据格式:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(527, 253);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(0, 14);
            this.label36.TabIndex = 159;
            this.label36.Visible = false;
            // 
            // tbPointName7
            // 
            this.tbPointName7.Location = new System.Drawing.Point(305, 248);
            this.tbPointName7.Name = "tbPointName7";
            this.tbPointName7.Size = new System.Drawing.Size(95, 23);
            this.tbPointName7.TabIndex = 158;
            this.tbPointName7.Text = "12-RTCM38";
            this.tbPointName7.TextChanged += new System.EventHandler(this.tbPointName7_TextChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.SystemColors.Control;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(259, 250);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(40, 17);
            this.label37.TabIndex = 157;
            this.label37.Text = "名称:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(361, 252);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(0, 14);
            this.label38.TabIndex = 156;
            this.label38.Visible = false;
            // 
            // txServerPort7
            // 
            this.txServerPort7.Location = new System.Drawing.Point(148, 247);
            this.txServerPort7.Name = "txServerPort7";
            this.txServerPort7.Size = new System.Drawing.Size(95, 23);
            this.txServerPort7.TabIndex = 155;
            this.txServerPort7.Text = "6067";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.SystemColors.Control;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(52, 248);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(75, 17);
            this.label39.TabIndex = 153;
            this.label39.Text = "TCP端口7:";
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.SystemColors.Control;
            this.bt7.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(708, 243);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(51, 30);
            this.bt7.TabIndex = 154;
            this.bt7.Text = "启动";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // cbFormat6
            // 
            this.cbFormat6.FormattingEnabled = true;
            this.cbFormat6.Items.AddRange(new object[] {
            "RTCM30",
            "RTCM32"});
            this.cbFormat6.Location = new System.Drawing.Point(486, 210);
            this.cbFormat6.Name = "cbFormat6";
            this.cbFormat6.Size = new System.Drawing.Size(102, 21);
            this.cbFormat6.TabIndex = 152;
            this.cbFormat6.Text = "RTCM32";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.SystemColors.Control;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(411, 212);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 17);
            this.label30.TabIndex = 151;
            this.label30.Text = "数据格式:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(527, 215);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(0, 14);
            this.label31.TabIndex = 150;
            this.label31.Visible = false;
            // 
            // tbPointName6
            // 
            this.tbPointName6.Location = new System.Drawing.Point(305, 210);
            this.tbPointName6.Name = "tbPointName6";
            this.tbPointName6.Size = new System.Drawing.Size(95, 23);
            this.tbPointName6.TabIndex = 149;
            this.tbPointName6.Text = "12-RTCM37";
            this.tbPointName6.TextChanged += new System.EventHandler(this.tbPointName6_TextChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.SystemColors.Control;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(259, 212);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(40, 17);
            this.label32.TabIndex = 148;
            this.label32.Text = "名称:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(361, 214);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(0, 14);
            this.label33.TabIndex = 147;
            this.label33.Visible = false;
            // 
            // txServerPort6
            // 
            this.txServerPort6.Location = new System.Drawing.Point(148, 209);
            this.txServerPort6.Name = "txServerPort6";
            this.txServerPort6.Size = new System.Drawing.Size(95, 23);
            this.txServerPort6.TabIndex = 146;
            this.txServerPort6.Text = "6066";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.SystemColors.Control;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(52, 210);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(75, 17);
            this.label34.TabIndex = 144;
            this.label34.Text = "TCP端口6:";
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.SystemColors.Control;
            this.bt6.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(708, 205);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(51, 30);
            this.bt6.TabIndex = 145;
            this.bt6.Text = "启动";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // cbFormat5
            // 
            this.cbFormat5.FormattingEnabled = true;
            this.cbFormat5.Items.AddRange(new object[] {
            "RTCM30",
            "RTCM32"});
            this.cbFormat5.Location = new System.Drawing.Point(486, 175);
            this.cbFormat5.Name = "cbFormat5";
            this.cbFormat5.Size = new System.Drawing.Size(102, 21);
            this.cbFormat5.TabIndex = 143;
            this.cbFormat5.Text = "RTCM32";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.Control;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(411, 177);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 17);
            this.label25.TabIndex = 142;
            this.label25.Text = "数据格式:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(527, 180);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 14);
            this.label26.TabIndex = 141;
            this.label26.Visible = false;
            // 
            // tbPointName5
            // 
            this.tbPointName5.Location = new System.Drawing.Point(305, 175);
            this.tbPointName5.Name = "tbPointName5";
            this.tbPointName5.Size = new System.Drawing.Size(95, 23);
            this.tbPointName5.TabIndex = 140;
            this.tbPointName5.Text = "12-RTCM36";
            this.tbPointName5.TextChanged += new System.EventHandler(this.tbPointName5_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.Control;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(259, 177);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 17);
            this.label27.TabIndex = 139;
            this.label27.Text = "名称:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(361, 179);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(0, 14);
            this.label28.TabIndex = 138;
            this.label28.Visible = false;
            // 
            // txServerPort5
            // 
            this.txServerPort5.Location = new System.Drawing.Point(148, 174);
            this.txServerPort5.Name = "txServerPort5";
            this.txServerPort5.Size = new System.Drawing.Size(95, 23);
            this.txServerPort5.TabIndex = 137;
            this.txServerPort5.Text = "6065";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.SystemColors.Control;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(52, 175);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 17);
            this.label29.TabIndex = 135;
            this.label29.Text = "TCP端口5:";
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.SystemColors.Control;
            this.bt5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(708, 170);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(51, 30);
            this.bt5.TabIndex = 136;
            this.bt5.Text = "启动";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // cbFormat4
            // 
            this.cbFormat4.FormattingEnabled = true;
            this.cbFormat4.Items.AddRange(new object[] {
            "RTCM30",
            "RTCM32"});
            this.cbFormat4.Location = new System.Drawing.Point(486, 138);
            this.cbFormat4.Name = "cbFormat4";
            this.cbFormat4.Size = new System.Drawing.Size(102, 21);
            this.cbFormat4.TabIndex = 134;
            this.cbFormat4.Text = "RTCM32";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Control;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(411, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 17);
            this.label20.TabIndex = 133;
            this.label20.Text = "数据格式:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(527, 143);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 14);
            this.label21.TabIndex = 132;
            this.label21.Visible = false;
            // 
            // tbPointName4
            // 
            this.tbPointName4.Location = new System.Drawing.Point(305, 138);
            this.tbPointName4.Name = "tbPointName4";
            this.tbPointName4.Size = new System.Drawing.Size(95, 23);
            this.tbPointName4.TabIndex = 131;
            this.tbPointName4.Text = "12-RTCM35";
            this.tbPointName4.TextChanged += new System.EventHandler(this.tbPointName4_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.Control;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(259, 140);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 17);
            this.label22.TabIndex = 130;
            this.label22.Text = "名称:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(361, 142);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 14);
            this.label23.TabIndex = 129;
            this.label23.Visible = false;
            // 
            // txServerPort4
            // 
            this.txServerPort4.Location = new System.Drawing.Point(148, 137);
            this.txServerPort4.Name = "txServerPort4";
            this.txServerPort4.Size = new System.Drawing.Size(95, 23);
            this.txServerPort4.TabIndex = 128;
            this.txServerPort4.Text = "6064";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Control;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(52, 138);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 17);
            this.label24.TabIndex = 126;
            this.label24.Text = "TCP端口4:";
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.SystemColors.Control;
            this.bt4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(708, 133);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(51, 30);
            this.bt4.TabIndex = 127;
            this.bt4.Text = "启动";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // cbFormat3
            // 
            this.cbFormat3.FormattingEnabled = true;
            this.cbFormat3.Items.AddRange(new object[] {
            "RTCM30",
            "RTCM32"});
            this.cbFormat3.Location = new System.Drawing.Point(486, 101);
            this.cbFormat3.Name = "cbFormat3";
            this.cbFormat3.Size = new System.Drawing.Size(102, 21);
            this.cbFormat3.TabIndex = 125;
            this.cbFormat3.Text = "RTCM32";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(411, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 17);
            this.label15.TabIndex = 124;
            this.label15.Text = "数据格式:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(527, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 14);
            this.label16.TabIndex = 123;
            this.label16.Visible = false;
            // 
            // tbPointName3
            // 
            this.tbPointName3.Location = new System.Drawing.Point(305, 101);
            this.tbPointName3.Name = "tbPointName3";
            this.tbPointName3.Size = new System.Drawing.Size(95, 23);
            this.tbPointName3.TabIndex = 122;
            this.tbPointName3.Text = "12-RTCM34";
            this.tbPointName3.TextChanged += new System.EventHandler(this.tbPointName3_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(259, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 17);
            this.label17.TabIndex = 121;
            this.label17.Text = "名称:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(361, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 14);
            this.label18.TabIndex = 120;
            this.label18.Visible = false;
            // 
            // txServerPort3
            // 
            this.txServerPort3.Location = new System.Drawing.Point(148, 100);
            this.txServerPort3.Name = "txServerPort3";
            this.txServerPort3.Size = new System.Drawing.Size(95, 23);
            this.txServerPort3.TabIndex = 119;
            this.txServerPort3.Text = "6063";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(52, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 17);
            this.label19.TabIndex = 117;
            this.label19.Text = "TCP端口3:";
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.SystemColors.Control;
            this.bt3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(708, 96);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(51, 30);
            this.bt3.TabIndex = 118;
            this.bt3.Text = "启动";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // cbFormat2
            // 
            this.cbFormat2.FormattingEnabled = true;
            this.cbFormat2.Items.AddRange(new object[] {
            "RTCM30",
            "RTCM32"});
            this.cbFormat2.Location = new System.Drawing.Point(486, 63);
            this.cbFormat2.Name = "cbFormat2";
            this.cbFormat2.Size = new System.Drawing.Size(102, 21);
            this.cbFormat2.TabIndex = 116;
            this.cbFormat2.Text = "RTCM32";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(411, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 115;
            this.label10.Text = "数据格式:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(527, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 14);
            this.label11.TabIndex = 114;
            this.label11.Visible = false;
            // 
            // tbPointName2
            // 
            this.tbPointName2.Location = new System.Drawing.Point(305, 63);
            this.tbPointName2.Name = "tbPointName2";
            this.tbPointName2.Size = new System.Drawing.Size(95, 23);
            this.tbPointName2.TabIndex = 113;
            this.tbPointName2.Text = "12-RTCM33";
            this.tbPointName2.TextChanged += new System.EventHandler(this.tbPointName2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(259, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 112;
            this.label12.Text = "名称:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(361, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 14);
            this.label13.TabIndex = 111;
            this.label13.Visible = false;
            // 
            // txServerPort2
            // 
            this.txServerPort2.Location = new System.Drawing.Point(148, 62);
            this.txServerPort2.Name = "txServerPort2";
            this.txServerPort2.Size = new System.Drawing.Size(95, 23);
            this.txServerPort2.TabIndex = 110;
            this.txServerPort2.Text = "6062";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(52, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 17);
            this.label14.TabIndex = 108;
            this.label14.Text = "TCP端口2:";
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.SystemColors.Control;
            this.bt2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(708, 58);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(51, 30);
            this.bt2.TabIndex = 109;
            this.bt2.Text = "启动";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // cbFormat
            // 
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "RTCM30",
            "RTCM32"});
            this.cbFormat.Location = new System.Drawing.Point(486, 25);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(102, 21);
            this.cbFormat.TabIndex = 107;
            this.cbFormat.Text = "RTCM32";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(411, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 106;
            this.label8.Text = "数据格式:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(527, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 14);
            this.label9.TabIndex = 105;
            this.label9.Visible = false;
            // 
            // tbPointName
            // 
            this.tbPointName.Location = new System.Drawing.Point(305, 25);
            this.tbPointName.Name = "tbPointName";
            this.tbPointName.Size = new System.Drawing.Size(95, 23);
            this.tbPointName.TabIndex = 104;
            this.tbPointName.Text = "12-RTCM32";
            this.tbPointName.TextChanged += new System.EventHandler(this.tbPointName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(259, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 103;
            this.label7.Text = "名称:";
            // 
            // btStartServer
            // 
            this.btStartServer.BackColor = System.Drawing.SystemColors.Control;
            this.btStartServer.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStartServer.Location = new System.Drawing.Point(623, 328);
            this.btStartServer.Name = "btStartServer";
            this.btStartServer.Size = new System.Drawing.Size(138, 30);
            this.btStartServer.TabIndex = 102;
            this.btStartServer.Text = "启动";
            this.btStartServer.UseVisualStyleBackColor = false;
            this.btStartServer.Click += new System.EventHandler(this.btStartServer_Click);
            // 
            // tbCasterPort
            // 
            this.tbCasterPort.Location = new System.Drawing.Point(141, 333);
            this.tbCasterPort.Name = "tbCasterPort";
            this.tbCasterPort.Size = new System.Drawing.Size(456, 23);
            this.tbCasterPort.TabIndex = 101;
            this.tbCasterPort.Text = "5000";
            this.tbCasterPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 100;
            this.label3.Text = "SERVER端口:";
            // 
            // lbTCPStatus
            // 
            this.lbTCPStatus.AutoSize = true;
            this.lbTCPStatus.Location = new System.Drawing.Point(361, 29);
            this.lbTCPStatus.Name = "lbTCPStatus";
            this.lbTCPStatus.Size = new System.Drawing.Size(0, 14);
            this.lbTCPStatus.TabIndex = 99;
            this.lbTCPStatus.Visible = false;
            // 
            // pbTCP
            // 
            this.pbTCP.Location = new System.Drawing.Point(48, 370);
            this.pbTCP.Name = "pbTCP";
            this.pbTCP.Size = new System.Drawing.Size(713, 23);
            this.pbTCP.TabIndex = 98;
            // 
            // txServerPort
            // 
            this.txServerPort.Location = new System.Drawing.Point(148, 24);
            this.txServerPort.Name = "txServerPort";
            this.txServerPort.Size = new System.Drawing.Size(95, 23);
            this.txServerPort.TabIndex = 97;
            this.txServerPort.Text = "6061";
            this.txServerPort.TextChanged += new System.EventHandler(this.txServerPort_TextChanged);
            this.txServerPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txServerPort_KeyPress);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(52, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 17);
            this.Label1.TabIndex = 79;
            this.Label1.Text = "TCP端口1:";
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
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.Control;
            this.bt1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(708, 20);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(51, 30);
            this.bt1.TabIndex = 86;
            this.bt1.Text = "启动";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
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
            this.rtbEvents.Size = new System.Drawing.Size(801, 230);
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
            this.tabControl1.Size = new System.Drawing.Size(817, 719);
            this.tabControl1.TabIndex = 80;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(809, 692);
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
            this.tabPage2.Size = new System.Drawing.Size(809, 692);
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
            this.dgvConnections.Size = new System.Drawing.Size(803, 686);
            this.dgvConnections.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvMountPoints);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(809, 692);
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
            this.dgvMountPoints.Size = new System.Drawing.Size(809, 692);
            this.dgvMountPoints.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(809, 692);
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
            this.splitContainer1.Size = new System.Drawing.Size(809, 692);
            this.splitContainer1.SplitterDistance = 640;
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
            this.dgvUsers.Size = new System.Drawing.Size(809, 640);
            this.dgvUsers.TabIndex = 7;
            // 
            // btAddUser
            // 
            this.btAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddUser.Location = new System.Drawing.Point(610, 13);
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
            this.btDelUser.Location = new System.Drawing.Point(676, 12);
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
            this.btEditUser.Location = new System.Drawing.Point(743, 12);
            this.btEditUser.Name = "btEditUser";
            this.btEditUser.Size = new System.Drawing.Size(58, 25);
            this.btEditUser.TabIndex = 10;
            this.btEditUser.Text = "编辑";
            this.btEditUser.UseVisualStyleBackColor = true;
            this.btEditUser.Click += new System.EventHandler(this.btEditUser_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.pictureBox1);
            this.tabPage6.Controls.Add(this.Label2);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.lblVersion);
            this.tabPage6.Location = new System.Drawing.Point(4, 23);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(809, 692);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "关于";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(315, 344);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(189, 20);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "GISERPENG@163.COM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "NTRIP Share2020";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(365, 308);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(89, 20);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "Version:1.0";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusBar});
            this.StatusStrip.Location = new System.Drawing.Point(0, 719);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(817, 22);
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
            this.timer2.Interval = 1800000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timerDog
            // 
            this.timerDog.Interval = 30000;
            this.timerDog.Tick += new System.EventHandler(this.timerDog_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::My.Resources.Resources.log;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 692);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TCPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(817, 741);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.StatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TCPForm";
            this.Text = "NTRIP Share2020";
            this.Activated += new System.EventHandler(this.TCPForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.VisibleChanged += new System.EventHandler(this.TCPForm_VisibleChanged);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
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
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.Timer Timer1;
        private System.ComponentModel.IContainer components;
        private SplitContainer splitContainer2;
        internal RichTextBox rtbEvents;
        internal Button btnClearLog;
        internal Label lbl3;
        internal Label lbl2;
        internal Label lblStatus;
        internal Button bt1;
        internal Label Label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage6;
        internal DataGridView dgvConnections;
        internal DataGridView dgvMountPoints;
        internal Label Label2;
        internal Label label4;
        internal Label lblVersion;
        internal DataGridView dgvUsers;
        internal StatusStrip StatusStrip;
        internal ToolStripStatusLabel lblStatusBar;
        private TextBox txServerPort;
        private ProgressBar pbTCP;
        private Label lbTCPStatus;
        internal Button btStartServer;
        private TextBox tbCasterPort;
        internal Label label3;
        private Button btAddUser;
        internal Button btDelUser;
        internal Button btEditUser;
        private ComboBox cbFormat;
        internal Label label8;
        private Label label9;
        private TextBox tbPointName;
        internal Label label7;
        internal Button button8;
        private ComboBox cbFormat8;
        internal Label label40;
        private Label label41;
        private TextBox tbPointName8;
        internal Label label42;
        private Label label43;
        private TextBox txServerPort8;
        internal Label label44;
        internal Button bt8;
        private ComboBox cbFormat7;
        internal Label label35;
        private Label label36;
        private TextBox tbPointName7;
        internal Label label37;
        private Label label38;
        private TextBox txServerPort7;
        internal Label label39;
        internal Button bt7;
        private ComboBox cbFormat6;
        internal Label label30;
        private Label label31;
        private TextBox tbPointName6;
        internal Label label32;
        private Label label33;
        private TextBox txServerPort6;
        internal Label label34;
        internal Button bt6;
        private ComboBox cbFormat5;
        internal Label label25;
        private Label label26;
        private TextBox tbPointName5;
        internal Label label27;
        private Label label28;
        private TextBox txServerPort5;
        internal Label label29;
        internal Button bt5;
        private ComboBox cbFormat4;
        internal Label label20;
        private Label label21;
        private TextBox tbPointName4;
        internal Label label22;
        private Label label23;
        private TextBox txServerPort4;
        internal Label label24;
        internal Button bt4;
        private ComboBox cbFormat3;
        internal Label label15;
        private Label label16;
        private TextBox tbPointName3;
        internal Label label17;
        private Label label18;
        private TextBox txServerPort3;
        internal Label label19;
        internal Button bt3;
        private ComboBox cbFormat2;
        internal Label label10;
        private Label label11;
        private TextBox tbPointName2;
        internal Label label12;
        private Label label13;
        private TextBox txServerPort2;
        internal Label label14;
        internal Button bt2;
        private SplitContainer splitContainer1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Timer timer2;
        private Label labelStartTime;
        private Timer timer3;
        private Timer timerDog;
        private PictureBox pictureBox1;
    }

}
