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

    public partial class NTRIPDialog
    {
        public NTRIPDialog()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static NTRIPDialog defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static NTRIPDialog Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new NTRIPDialog();
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
            //defaultInstance = null;
        }

        #endregion

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


        public void boxProtocol_SelectionChangeCommitted(System.Object sender, System.EventArgs e)
        {
            RefreshDisplayedItems();
        }

        public void boxManualGGA_SelectionChangeCommitted(System.Object sender, System.EventArgs e)
        {
            RefreshDisplayedItems();
        }

        public void RefreshDisplayedItems()
        {
            if (boxProtocol.SelectedIndex == 0) //Raw TCP/IP
            {
                lblUsername.Visible = false;
                tbUsername.Visible = false;
                lblPassword.Visible = false;
                tbPassword.Visible = false;

                GroupBox1.Text = "TCP/IP服务器设置";

                GroupBox2.Visible = false;

            }
            else //NTRIP
            {
                lblUsername.Visible = true;
                tbUsername.Visible = true;
                lblPassword.Visible = true;
                tbPassword.Visible = true;

                GroupBox1.Text = "NTRIP服务器设置";

                GroupBox2.Visible = true;

                if (boxManualGGA.SelectedIndex == 0)
                {
                    //lblLat.Text = "Send in position data:"
                    //boxSendGGAFreq.Visible = True
                    lblLat.Visible = false;
                    lblLon.Visible = false;
                    tbLatitude.Visible = false;
                    tbLongitude.Visible = false;
                }
                else
                {
                    //lblLat.Text = "Latitude:"
                    //boxSendGGAFreq.Visible = False
                    lblLat.Visible = true;
                    lblLon.Visible = true;
                    tbLatitude.Visible = true;
                    tbLongitude.Visible = true;
                }
            }
        }

    }

}
