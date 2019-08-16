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
 * Description: This Form includes Three Buttons to Start new order
 *              , Open Existing Order and Cancel.
 */

namespace COMP123_S2019_A5_301044883.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is an event handler for
        /// the Start order Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartOrderButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        /// <summary>
        /// This is the event Handler for the
        /// open Saved Order Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
            Program.productInfoForm.OpenSavedOrder();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
