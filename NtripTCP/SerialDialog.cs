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
	
	public partial class SerialDialog
	{
		public SerialDialog()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static SerialDialog defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
public static SerialDialog Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new SerialDialog();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		public void boxReceiverType_SelectionChangeCommitted(System.Object sender, System.EventArgs e)
		{
			RedisplayAutoConfigOptions(boxReceiverType.SelectedIndex);
		}
		
		public void RedisplayAutoConfigOptions(int ReceiverType)
		{
			//switch (ReceiverType)
			//{
			//	case 1:
			//		boxCorrDataType.Items.Clear();
			//		boxCorrDataType.Items.Add("RTCM v2");
			//		boxCorrDataType.Items.Add("RTCM v3");
			//		boxCorrDataType.Items.Add("CMR or CMR+");
			//		boxCorrDataType.Items.Add("RTCA");
			//		boxCorrDataType.Items.Add("OmniSTAR");
			//		boxCorrDataType.Items.Add("NovAtel");
			//		switch (NTRIPClient.MainForm.Default.ReceiverCorrDataType.ToLower())
			//		{
			//			case "rtcm":
			//				boxCorrDataType.SelectedIndex = 0;
			//				break;
			//			case "rtcmv3":
			//				boxCorrDataType.SelectedIndex = 1;
			//				break;
			//			case "cmr":
			//				boxCorrDataType.SelectedIndex = 2;
			//				break;
			//			case "rtca":
			//				boxCorrDataType.SelectedIndex = 3;
			//				break;
			//			case "omnistar":
			//				boxCorrDataType.SelectedIndex = 4;
			//				break;
			//			default:
			//				boxCorrDataType.SelectedIndex = 5;
			//				break;
			//		}
			//		lblCorrDataType.Visible = true;
			//		boxCorrDataType.Visible = true;
					
			//		switch (NTRIPClient.MainForm.Default.ReceiverMessageRate)
			//		{
			//			case 5:
			//				boxMsgRate.SelectedIndex = 1;
			//				break;
			//			case 10:
			//				boxMsgRate.SelectedIndex = 2;
			//				break;
			//			default:
			//				boxMsgRate.SelectedIndex = 0;
			//				break;
			//		}
					
			//		lblMsgRate.Visible = true;
			//		boxMsgRate.Visible = true;
			//		break;
					
					
			//	default:
			//		lblCorrDataType.Visible = false;
			//		boxCorrDataType.Visible = false;
					
			//		lblMsgRate.Visible = false;
			//		boxMsgRate.Visible = false;
			//		break;
			//}
		}
		
		
		
		public void OK_Button_Click(System.Object sender, System.EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}
		
		public void Cancel_Button_Click(System.Object sender, System.EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}
		
		
		
	}
	
}
