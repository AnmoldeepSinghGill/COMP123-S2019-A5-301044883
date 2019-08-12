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

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ManufacturerTextLabel.Text = Program.product.manufacturer;
            ModelTextLabel.Text = Program.product.model;
            MemoryTextLabel.Text = Program.product.RAM_size;
            LCDSizeTextLabel.Text = Program.product.screensize;
            CPUBrandTextLabel.Text = Program.product.CPU_brand;
            CPUTypeTextLabel.Text = Program.product.CPU_type;
            LCDSizeTextLabel.Text = Program.product.screensize;
            CPUNumberTextLabel.Text = Program.product.CPU_number;
            HDDTextLabel.Text = Program.product.HDD_size;
            CPUSpeedTextLabel.Text = Program.product.CPU_speed;
            GPUTypeTextLabel.Text = Program.product.GPU_Type;
            WebCamTextLabel.Text = Program.product.webcam;
            OSTextLabel.Text = Program.product.OS;
            PlatformTextLabel.Text = Program.product.platform;
            ConditionTextLabel.Text = Program.product.condition;
            PriceTextLabel.Text = "$" + Program.product.cost.ToString();

            var salesTax = (Program.product.cost / 100) * 13;

            SalesTaxTextLabel.Text = "$" + salesTax.ToString();

            var totalPrice = Program.product.cost + salesTax;

            TotalPriceTextLabel.Text = "$" + totalPrice.ToString();
        }
    }
}
