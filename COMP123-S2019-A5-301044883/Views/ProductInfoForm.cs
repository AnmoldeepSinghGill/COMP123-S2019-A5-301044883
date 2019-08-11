using COMP123_S2019_A5_301044883.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301044883.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void ExitAplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            //Assigns the value from properties to respective textboxes
            Program.productInfoForm.ProductIDTextLabel.Text = Program.product.productID.ToString();
            Program.productInfoForm.ManufacturerTextLabel.Text = Program.product.manufacturer;
            Program.productInfoForm.ModelTextLabel.Text = Program.product.model;
            Program.productInfoForm.MemoryTextLabel.Text = Program.product.RAM_size;
            Program.productInfoForm.LCDSizeTextLabel.Text = Program.product.screensize;
            Program.productInfoForm.CPUBrandTextLabel.Text = Program.product.CPU_brand;
            Program.productInfoForm.CPUTypeTextLabel.Text = Program.product.CPU_type;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open Sterem Writer to write
            using (StreamWriter outputString = new StreamWriter(
                File.Open("Computer.txt", FileMode.Create)))
            {
                //Write strings to File
                outputString.WriteLine("ProductID: " + Program.product.productID.ToString());
                outputString.WriteLine("Manufacturer: " + Program.product.manufacturer);
                outputString.WriteLine("ModelLabel: " + Program.product.model);
                outputString.WriteLine("Memory: " + Program.product.RAM_size);
                outputString.WriteLine("LCD Size: " + Program.product.screensize);
                outputString.WriteLine("CPU Brand: " + Program.product.CPU_brand);
                outputString.WriteLine("CPU Type: " + Program.product.CPU_type);

                // close 
                outputString.Close();
                outputString.Dispose();
            }

            MessageBox.Show("File Saved Succesfully!", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
