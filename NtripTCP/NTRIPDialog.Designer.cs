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
	partial class NTRIPDialog : System.Windows.Forms.Form
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
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.boxManualGGA = new System.Windows.Forms.ComboBox();
            this.lblLon = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.GroupBox0 = new System.Windows.Forms.GroupBox();
            this.boxProtocol = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox0.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLayoutPanel1.Location = new System.Drawing.Point(277, 365);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 32);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(76, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 26);
            this.Cancel_Button.TabIndex = 9;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 26);
            this.OK_Button.TabIndex = 8;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(38, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 17);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "IP地址:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(50, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 17);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "端口:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(36, 79);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(54, 17);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "用户名:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(50, 109);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(40, 17);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "密码:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(21, 24);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(163, 15);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "请选择当前位置数据输入方式";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.tbPassword);
            this.GroupBox1.Controls.Add(this.tbUsername);
            this.GroupBox1.Controls.Add(this.tbPort);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.tbAddress);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.lblPassword);
            this.GroupBox1.Controls.Add(this.lblUsername);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 68);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(407, 138);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "NTRIP Caster设置";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPassword.Location = new System.Drawing.Point(115, 106);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(284, 22);
            this.tbPassword.TabIndex = 4;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbUsername.Location = new System.Drawing.Point(115, 77);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(284, 22);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPort.Location = new System.Drawing.Point(115, 47);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(284, 22);
            this.tbPort.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAddress.Location = new System.Drawing.Point(115, 18);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(284, 22);
            this.tbAddress.TabIndex = 1;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.tbLongitude);
            this.GroupBox2.Controls.Add(this.tbLatitude);
            this.GroupBox2.Controls.Add(this.boxManualGGA);
            this.GroupBox2.Controls.Add(this.lblLon);
            this.GroupBox2.Controls.Add(this.lblLat);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(12, 211);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(407, 141);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "位置";
            // 
            // tbLongitude
            // 
            this.tbLongitude.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLongitude.Location = new System.Drawing.Point(115, 111);
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.Size = new System.Drawing.Size(161, 22);
            this.tbLongitude.TabIndex = 7;
            // 
            // tbLatitude
            // 
            this.tbLatitude.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLatitude.Location = new System.Drawing.Point(115, 84);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(161, 22);
            this.tbLatitude.TabIndex = 6;
            // 
            // boxManualGGA
            // 
            this.boxManualGGA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxManualGGA.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.boxManualGGA.FormattingEnabled = true;
            this.boxManualGGA.Items.AddRange(new object[] {
            "使用串口输入坐标",
            "使用模拟坐标"});
            this.boxManualGGA.Location = new System.Drawing.Point(22, 50);
            this.boxManualGGA.Name = "boxManualGGA";
            this.boxManualGGA.Size = new System.Drawing.Size(377, 21);
            this.boxManualGGA.TabIndex = 5;
            this.boxManualGGA.SelectionChangeCommitted += new System.EventHandler(this.boxManualGGA_SelectionChangeCommitted);
            // 
            // lblLon
            // 
            this.lblLon.AutoSize = true;
            this.lblLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLon.Location = new System.Drawing.Point(50, 114);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(40, 17);
            this.lblLon.TabIndex = 8;
            this.lblLon.Text = "经度:";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(50, 87);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(40, 17);
            this.lblLat.TabIndex = 7;
            this.lblLat.Text = "纬度:";
            // 
            // GroupBox0
            // 
            this.GroupBox0.Controls.Add(this.boxProtocol);
            this.GroupBox0.Controls.Add(this.Label7);
            this.GroupBox0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox0.Location = new System.Drawing.Point(13, 11);
            this.GroupBox0.Name = "GroupBox0";
            this.GroupBox0.Size = new System.Drawing.Size(407, 52);
            this.GroupBox0.TabIndex = 7;
            this.GroupBox0.TabStop = false;
            this.GroupBox0.Text = "连接类型";
            // 
            // boxProtocol
            // 
            this.boxProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxProtocol.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.boxProtocol.FormattingEnabled = true;
            this.boxProtocol.Items.AddRange(new object[] {
            "Raw TCP/IP",
            "NTRIP v1.0"});
            this.boxProtocol.Location = new System.Drawing.Point(115, 18);
            this.boxProtocol.Name = "boxProtocol";
            this.boxProtocol.Size = new System.Drawing.Size(283, 21);
            this.boxProtocol.TabIndex = 8;
            this.boxProtocol.SelectionChangeCommitted += new System.EventHandler(this.boxProtocol_SelectionChangeCommitted);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(50, 20);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(40, 17);
            this.Label7.TabIndex = 1;
            this.Label7.Text = "协议:";
            // 
            // NTRIPDialog
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(435, 402);
            this.Controls.Add(this.GroupBox0);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NTRIPDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NTRIP设置";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox0.ResumeLayout(false);
            this.GroupBox0.PerformLayout();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Button OK_Button;
		internal System.Windows.Forms.Button Cancel_Button;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label lblUsername;
		internal System.Windows.Forms.Label lblPassword;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Label lblLon;
		internal System.Windows.Forms.Label lblLat;
		internal System.Windows.Forms.ComboBox boxManualGGA;
		internal System.Windows.Forms.TextBox tbPassword;
		internal System.Windows.Forms.TextBox tbUsername;
		internal System.Windows.Forms.TextBox tbPort;
		internal System.Windows.Forms.TextBox tbAddress;
		internal System.Windows.Forms.TextBox tbLongitude;
		internal System.Windows.Forms.TextBox tbLatitude;
		internal System.Windows.Forms.GroupBox GroupBox0;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.ComboBox boxProtocol;
		
	}
	
}
