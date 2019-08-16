using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Anmoldeep Singh Gill
 * Student ID: 301044883
 * Created on: 31 July 2019
 * Description: This is a Splash Form which is 
 *              shown as the welcome screen for 3 seconds 
 *              before the start form is shown.
 */

namespace COMP123_S2019_A5_301044883.Views
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is event handler for tick event for the 
        /// SplashTimer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            Program.startForm.Show();
            this.Hide();
            SplashTimer.Enabled = false;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
    }
}
