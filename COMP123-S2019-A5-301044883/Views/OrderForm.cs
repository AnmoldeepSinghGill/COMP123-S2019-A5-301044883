using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301044883.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for Ordering Your Computer. \nYour Order will be Processed in 7-10 days.");
            Application.Exit();
        }
    }
}
