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

    public partial class UserDialog
    {
        public UserDialog()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static UserDialog defaultInstance;
        public string userName { get; set; }
        public string password { get; set; }
        public string des { get; set; }
        public DateTime time { get; set; }

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static UserDialog Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new UserDialog();
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

        public void OK_Button_Click(System.Object sender, System.EventArgs e)
        {
            if (tbUsername.Text.Trim().Length == 0)
            {
                MessageBox.Show("用户名不能为空");
                return;
            }
            if (tbPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("密码不能为空");
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
           
        }

        public void Cancel_Button_Click(System.Object sender, System.EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btWeek_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddDays(7.0);
        }

        private void btMonth_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddDays(30.0);
        }

        private void btYear_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddYears(1);
        }

        private void btNoLimit_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddYears(100);
        }
    }

}
