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
	partial class OptionsDialog : System.Windows.Forms.Form
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
			this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
			this.Cancel_Button = new System.Windows.Forms.Button();
			this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
			this.Label1 = new System.Windows.Forms.Label();
			this.boxText2 = new System.Windows.Forms.ComboBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.boxText3 = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.btnAudioHelp = new System.Windows.Forms.Button();
			this.btnAudioHelp.Click += new System.EventHandler(this.btnAudioHelp_Click);
			this.Label13 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.boxAudioFile = new System.Windows.Forms.ComboBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.boxDoLogging = new System.Windows.Forms.ComboBox();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.boxDoSaveNMEA = new System.Windows.Forms.ComboBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.boxCheckWeekly = new System.Windows.Forms.ComboBox();
			this.btnCheckForUpdatesNow = new System.Windows.Forms.Button();
			this.btnCheckForUpdatesNow.Click += new System.EventHandler(this.btnCheckForUpdatesNow_Click);
			this.TableLayoutPanel1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.SuspendLayout();
			//
			//TableLayoutPanel1
			//
			this.TableLayoutPanel1.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float) (50.0F)));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float) (50.0F)));
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(277, 556);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float) (50.0F)));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, (float) (35.0F)));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 35);
			this.TableLayoutPanel1.TabIndex = 0;
			//
			//OK_Button
			//
			this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.OK_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.OK_Button.Location = new System.Drawing.Point(3, 3);
			this.OK_Button.Name = "OK_Button";
			this.OK_Button.Size = new System.Drawing.Size(67, 29);
			this.OK_Button.TabIndex = 0;
			this.OK_Button.Text = "OK";
			//
			//Cancel_Button
			//
			this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Cancel_Button.Location = new System.Drawing.Point(76, 3);
			this.Cancel_Button.Name = "Cancel_Button";
			this.Cancel_Button.Size = new System.Drawing.Size(67, 29);
			this.Cancel_Button.TabIndex = 1;
			this.Cancel_Button.Text = "Cancel";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(32, 59);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(61, 20);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Center:";
			//
			//boxText2
			//
			this.boxText2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.boxText2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.boxText2.FormattingEnabled = true;
			this.boxText2.Items.AddRange(new object[] {"Nothing", "Correction Age", "H-DOP", "V-DOP", "P-DOP", "Elevation (Feet)", "Elevation (Meters)", "Speed (MPH)", "Speed (MPH, Smoothed)", "Speed (Km/h)", "Speed (Km/h, Smoothed)", "Heading"});
			this.boxText2.Location = new System.Drawing.Point(98, 56);
			this.boxText2.Name = "boxText2";
			this.boxText2.Size = new System.Drawing.Size(303, 28);
			this.boxText2.TabIndex = 7;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.boxText3);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.boxText2);
			this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GroupBox1.Location = new System.Drawing.Point(16, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(407, 182);
			this.GroupBox1.TabIndex = 15;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Top Line Display";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(6, 150);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(372, 20);
			this.Label5.TabIndex = 19;
			this.Label5.Text = "* GSA sentences are required for VDOP and PDOP";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6.Location = new System.Drawing.Point(6, 130);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(391, 20);
			this.Label6.TabIndex = 18;
			this.Label6.Text = "* RMC sentences are required for Speed and Heading";
			//
			//boxText3
			//
			this.boxText3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.boxText3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.boxText3.FormattingEnabled = true;
			this.boxText3.Items.AddRange(new object[] {"Nothing", "Correction Age", "H-DOP", "V-DOP", "P-DOP", "Elevation (Feet)", "Elevation (Meters)", "Speed (MPH)", "Speed (MPH, Smoothed)", "Speed (Km/h)", "Speed (Km/h, Smoothed)", "Heading"});
			this.boxText3.Location = new System.Drawing.Point(98, 90);
			this.boxText3.Name = "boxText3";
			this.boxText3.Size = new System.Drawing.Size(303, 28);
			this.boxText3.TabIndex = 10;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(6, 93);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(87, 20);
			this.Label3.TabIndex = 9;
			this.Label3.Text = "Right Side:";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(16, 25);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(324, 20);
			this.Label2.TabIndex = 8;
			this.Label2.Text = "Left Side:   GPS Fix Type and Satellite Count";
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.btnAudioHelp);
			this.GroupBox2.Controls.Add(this.Label13);
			this.GroupBox2.Controls.Add(this.Label12);
			this.GroupBox2.Controls.Add(this.Label11);
			this.GroupBox2.Controls.Add(this.boxAudioFile);
			this.GroupBox2.Controls.Add(this.Label9);
			this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GroupBox2.Location = new System.Drawing.Point(16, 210);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(407, 121);
			this.GroupBox2.TabIndex = 16;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Alerts";
			//
			//btnAudioHelp
			//
			this.btnAudioHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAudioHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btnAudioHelp.Location = new System.Drawing.Point(365, 53);
			this.btnAudioHelp.Name = "btnAudioHelp";
			this.btnAudioHelp.Size = new System.Drawing.Size(36, 29);
			this.btnAudioHelp.TabIndex = 18;
			this.btnAudioHelp.Text = "?";
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label13.Location = new System.Drawing.Point(2, 90);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(293, 20);
			this.Label13.TabIndex = 18;
			this.Label13.Text = "- When the NTRIP connection times out.";
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label12.Location = new System.Drawing.Point(2, 70);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(273, 20);
			this.Label12.TabIndex = 17;
			this.Label12.Text = "- When the Base Station ID changes.";
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label11.Location = new System.Drawing.Point(2, 50);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(256, 20);
			this.Label11.TabIndex = 16;
			this.Label11.Text = "- When the GPS Fix Type changes.";
			//
			//boxAudioFile
			//
			this.boxAudioFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.boxAudioFile.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.boxAudioFile.FormattingEnabled = true;
			this.boxAudioFile.Items.AddRange(new object[] {"No", "Yes"});
			this.boxAudioFile.Location = new System.Drawing.Point(114, 19);
			this.boxAudioFile.Name = "boxAudioFile";
			this.boxAudioFile.Size = new System.Drawing.Size(287, 28);
			this.boxAudioFile.TabIndex = 15;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(2, 22);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(109, 20);
			this.Label9.TabIndex = 15;
			this.Label9.Text = "Play audio file:";
			//
			//boxDoLogging
			//
			this.boxDoLogging.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.boxDoLogging.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.boxDoLogging.FormattingEnabled = true;
			this.boxDoLogging.Items.AddRange(new object[] {"No", "Yes"});
			this.boxDoLogging.Location = new System.Drawing.Point(313, 19);
			this.boxDoLogging.Name = "boxDoLogging";
			this.boxDoLogging.Size = new System.Drawing.Size(88, 28);
			this.boxDoLogging.TabIndex = 15;
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.Label4);
			this.GroupBox3.Controls.Add(this.boxDoSaveNMEA);
			this.GroupBox3.Controls.Add(this.Label10);
			this.GroupBox3.Controls.Add(this.boxDoLogging);
			this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GroupBox3.Location = new System.Drawing.Point(16, 347);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(407, 93);
			this.GroupBox3.TabIndex = 17;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "LoGG ing";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(6, 56);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(303, 20);
			this.Label4.TabIndex = 17;
			this.Label4.Text = "Record NMEA in /nmea/YYYYMMDD.txt?";
			//
			//boxDoSaveNMEA
			//
			this.boxDoSaveNMEA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.boxDoSaveNMEA.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.boxDoSaveNMEA.FormattingEnabled = true;
			this.boxDoSaveNMEA.Items.AddRange(new object[] {"No", "Yes"});
			this.boxDoSaveNMEA.Location = new System.Drawing.Point(313, 53);
			this.boxDoSaveNMEA.Name = "boxDoSaveNMEA";
			this.boxDoSaveNMEA.Size = new System.Drawing.Size(88, 28);
			this.boxDoSaveNMEA.TabIndex = 16;
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label10.Location = new System.Drawing.Point(6, 22);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(301, 20);
			this.Label10.TabIndex = 15;
			this.Label10.Text = "Record Events in /Logs/YYYYMMDD.txt?";
			//
			//GroupBox4
			//
			this.GroupBox4.Controls.Add(this.btnCheckForUpdatesNow);
			this.GroupBox4.Controls.Add(this.Label8);
			this.GroupBox4.Controls.Add(this.boxCheckWeekly);
			this.GroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GroupBox4.Location = new System.Drawing.Point(16, 455);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(407, 93);
			this.GroupBox4.TabIndex = 18;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Updates";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8.Location = new System.Drawing.Point(6, 22);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(168, 20);
			this.Label8.TabIndex = 15;
			this.Label8.Text = "Check for new version:";
			//
			//boxCheckWeekly
			//
			this.boxCheckWeekly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.boxCheckWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.boxCheckWeekly.FormattingEnabled = true;
			this.boxCheckWeekly.Items.AddRange(new object[] {"Never", "Weekly"});
			this.boxCheckWeekly.Location = new System.Drawing.Point(264, 19);
			this.boxCheckWeekly.Name = "boxCheckWeekly";
			this.boxCheckWeekly.Size = new System.Drawing.Size(137, 28);
			this.boxCheckWeekly.TabIndex = 15;
			//
			//btnCheckForUpdatesNow
			//
			this.btnCheckForUpdatesNow.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCheckForUpdatesNow.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btnCheckForUpdatesNow.Location = new System.Drawing.Point(167, 53);
			this.btnCheckForUpdatesNow.Name = "btnCheckForUpdatesNow";
			this.btnCheckForUpdatesNow.Size = new System.Drawing.Size(234, 29);
			this.btnCheckForUpdatesNow.TabIndex = 19;
			this.btnCheckForUpdatesNow.Text = "Check and Download Now";
			//
			//OptionsDialog
			//
			this.AcceptButton = this.OK_Button;
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_Button;
			this.ClientSize = new System.Drawing.Size(435, 597);
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.TableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionsDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Serial Port Settings";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Button OK_Button;
		internal System.Windows.Forms.Button Cancel_Button;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ComboBox boxText2;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.ComboBox boxDoLogging;
		internal System.Windows.Forms.ComboBox boxAudioFile;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Button btnAudioHelp;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ComboBox boxText3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.ComboBox boxDoSaveNMEA;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.ComboBox boxCheckWeekly;
		internal System.Windows.Forms.Button btnCheckForUpdatesNow;
		
	}
	
}
