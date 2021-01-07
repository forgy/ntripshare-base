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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class SerialDialog : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
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
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.boxSerialPort = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.boxSpeed = new System.Windows.Forms.ComboBox();
            this.boxDataBits = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.boxMsgRate = new System.Windows.Forms.ComboBox();
            this.lblMsgRate = new System.Windows.Forms.Label();
            this.boxCorrDataType = new System.Windows.Forms.ComboBox();
            this.lblCorrDataType = new System.Windows.Forms.Label();
            this.boxReceiverType = new System.Windows.Forms.ComboBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(277, 316);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 32);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 26);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.Location = new System.Drawing.Point(76, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 26);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(6, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(40, 17);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "端口:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(2, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(54, 17);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "波特率:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(13, 83);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 17);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Data Bits:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(40, 114);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 17);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Parity:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(14, 146);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 17);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "Stop Bits:";
            // 
            // boxSerialPort
            // 
            this.boxSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSerialPort.FormattingEnabled = true;
            this.boxSerialPort.Location = new System.Drawing.Point(98, 18);
            this.boxSerialPort.Name = "boxSerialPort";
            this.boxSerialPort.Size = new System.Drawing.Size(303, 24);
            this.boxSerialPort.TabIndex = 7;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(254, 52);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 17);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "bits/second";
            // 
            // boxSpeed
            // 
            this.boxSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSpeed.FormattingEnabled = true;
            this.boxSpeed.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.boxSpeed.Location = new System.Drawing.Point(98, 49);
            this.boxSpeed.Name = "boxSpeed";
            this.boxSpeed.Size = new System.Drawing.Size(150, 24);
            this.boxSpeed.TabIndex = 9;
            // 
            // boxDataBits
            // 
            this.boxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDataBits.FormattingEnabled = true;
            this.boxDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.boxDataBits.Location = new System.Drawing.Point(98, 80);
            this.boxDataBits.Name = "boxDataBits";
            this.boxDataBits.Size = new System.Drawing.Size(77, 24);
            this.boxDataBits.TabIndex = 10;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(98, 114);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(42, 17);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "None";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(98, 146);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(16, 17);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "1";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.boxDataBits);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.boxSpeed);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.boxSerialPort);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(16, 11);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(407, 174);
            this.GroupBox1.TabIndex = 15;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "串口设置";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.boxMsgRate);
            this.GroupBox2.Controls.Add(this.lblMsgRate);
            this.GroupBox2.Controls.Add(this.boxCorrDataType);
            this.GroupBox2.Controls.Add(this.lblCorrDataType);
            this.GroupBox2.Controls.Add(this.boxReceiverType);
            this.GroupBox2.Controls.Add(this.Label15);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(16, 190);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(407, 117);
            this.GroupBox2.TabIndex = 16;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "接收机配置";
            // 
            // boxMsgRate
            // 
            this.boxMsgRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxMsgRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMsgRate.FormattingEnabled = true;
            this.boxMsgRate.Items.AddRange(new object[] {
            "1 Hz",
            "5 Hz",
            "10 Hz"});
            this.boxMsgRate.Location = new System.Drawing.Point(162, 80);
            this.boxMsgRate.Name = "boxMsgRate";
            this.boxMsgRate.Size = new System.Drawing.Size(239, 24);
            this.boxMsgRate.TabIndex = 17;
            // 
            // lblMsgRate
            // 
            this.lblMsgRate.AutoSize = true;
            this.lblMsgRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgRate.Location = new System.Drawing.Point(2, 83);
            this.lblMsgRate.Name = "lblMsgRate";
            this.lblMsgRate.Size = new System.Drawing.Size(133, 17);
            this.lblMsgRate.TabIndex = 16;
            this.lblMsgRate.Text = "GGA/RMC消息频率:";
            // 
            // boxCorrDataType
            // 
            this.boxCorrDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCorrDataType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCorrDataType.FormattingEnabled = true;
            this.boxCorrDataType.Location = new System.Drawing.Point(121, 49);
            this.boxCorrDataType.Name = "boxCorrDataType";
            this.boxCorrDataType.Size = new System.Drawing.Size(280, 24);
            this.boxCorrDataType.TabIndex = 15;
            // 
            // lblCorrDataType
            // 
            this.lblCorrDataType.AutoSize = true;
            this.lblCorrDataType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrDataType.Location = new System.Drawing.Point(2, 52);
            this.lblCorrDataType.Name = "lblCorrDataType";
            this.lblCorrDataType.Size = new System.Drawing.Size(96, 17);
            this.lblCorrDataType.TabIndex = 10;
            this.lblCorrDataType.Text = "差分数据格式:";
            // 
            // boxReceiverType
            // 
            this.boxReceiverType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxReceiverType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxReceiverType.FormattingEnabled = true;
            this.boxReceiverType.Items.AddRange(new object[] {
            "不使用自动配置",
            "NovAtel OEMV Family"});
            this.boxReceiverType.Location = new System.Drawing.Point(102, 18);
            this.boxReceiverType.Name = "boxReceiverType";
            this.boxReceiverType.Size = new System.Drawing.Size(299, 24);
            this.boxReceiverType.TabIndex = 9;
            this.boxReceiverType.SelectionChangeCommitted += new System.EventHandler(this.boxReceiverType_SelectionChangeCommitted);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(2, 20);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(82, 17);
            this.Label15.TabIndex = 6;
            this.Label15.Text = "接收机类型:";
            // 
            // SerialDialog
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(435, 354);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerialDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "串口设置";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Button OK_Button;
		internal System.Windows.Forms.Button Cancel_Button;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.ComboBox boxSerialPort;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.ComboBox boxSpeed;
		internal System.Windows.Forms.ComboBox boxDataBits;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.ComboBox boxReceiverType;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label lblCorrDataType;
		internal System.Windows.Forms.ComboBox boxCorrDataType;
		internal System.Windows.Forms.ComboBox boxMsgRate;
		internal System.Windows.Forms.Label lblMsgRate;
		
	}
	
}
