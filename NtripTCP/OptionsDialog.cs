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
	
	public partial class OptionsDialog
	{
		public OptionsDialog()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static OptionsDialog defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
public static OptionsDialog Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new OptionsDialog();
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
		public void btnAudioHelp_Click(System.Object sender, System.EventArgs e)
		{
			MessageBox.Show("To select an audio alert, you will need to put a .wav file in the same folder as this application.");
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
		
		
		public void btnCheckForUpdatesNow_Click(System.Object sender, System.EventArgs e)
		{
			//NTRIPClient.MainForm.Default.CheckForUpdates(true);
		}
	}
	
}
