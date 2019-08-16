using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123_S2019_A5_301044883;
using COMP123_S2019_A5_301044883.Properties;

/*
 * Author: Anmoldeep Singh Gill
 * Student ID: 301044883
 * Created on: 31 July 2019
 * Description: This Form gets all the details of the
 *              product that is selected and displays 
 *              them with the picture of Platform and 
 *              Total price with Tax.
 */

namespace COMP123_S2019_A5_301044883.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method populates the data in the labels of the 
        /// order form, when the form is activated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            PriceTextLabel.Text = String.Format("{0:C}", Program.product.cost);

            // Assigned the sales tax calculation to salesTax variable
            double salesTax = Math.Round(Convert.ToDouble(Program.product.cost / 100 * 13), 2, MidpointRounding.ToEven);

            // Assigns the calculated sales tax to the textbox and formats it
            SalesTaxTextLabel.Text = "$" + salesTax.ToString();

            // Assigned the total price calculation to totalPrice variable
            double totalPrice = Convert.ToDouble(Program.product.cost) + salesTax;

            // Assigns the calculated total Price to the  Total price textbox and formats it
            TotalPriceTextLabel.Text = String.Format("{0:C}", totalPrice);

            // Changes the Image as the Platform Changes in Platform Label
            if (PlatformTextLabel.Text == "Laptop")
            {
                PlatformPictureBox.Image = Resources.LaptopPic;
            }
            else if (PlatformTextLabel.Text == "Desktop PC")
            {
                PlatformPictureBox.Image = Resources.Desktop;
            }

        }

        /// <summary>
        /// This is event handler for the about Button on Tool Strip
        /// and it opens the about form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.Show();
        }

        /// <summary>
        /// This is event handler for the Back Button and 
        /// it brings back the product info form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This event handler closes the whole applicatiion when the 
        /// Order Form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method shows the Message box for order Conformation
        /// and its delivery schedule.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for Ordering Your Computer. \nYour Order will be Processed in 7-10 days.");
            Application.Exit();
        }

        /// <summary>
        /// This is an event handler for the Print Button 
        /// on Menubar of the Order Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order is being Printed", "Printing...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
