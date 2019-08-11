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

            var ProductDataGridView = Program.selectForm.ProductDataGridView;

            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductDataGridView.Rows[rowIndex];

            // Assigns the value from different colums to variables
            var productID = currentRow.Cells[0].Value.ToString();
            var cost = currentRow.Cells[1].Value.ToString();
            var manufacturer = currentRow.Cells[2].Value.ToString();
            var model = currentRow.Cells[3].Value.ToString();
            var memory = currentRow.Cells[5].Value.ToString();
            var LCDsize = currentRow.Cells[7].Value.ToString();
            var cpuBrand = currentRow.Cells[10].Value.ToString();
            var cpuType = currentRow.Cells[9].Value.ToString();


            //Assigns the value from variables to respective textboxes
            Program.productInfoForm.ProductIDTextLabel.Text = productID;
            Program.productInfoForm.ManufacturerTextLabel.Text = manufacturer;
            Program.productInfoForm.ModelTextLabel.Text = model;
            Program.productInfoForm.MemoryTextLabel.Text = memory;
            Program.productInfoForm.LCDSizeTextLabel.Text = LCDsize;
            Program.productInfoForm.CPUBrandTextLabel.Text = cpuBrand;
            Program.productInfoForm.CPUTypeTextLabel.Text = cpuType;
            //Program.productInfoForm.ProductIDTextLabel.Text = productID;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open Sterem Writer to write
            using (StreamWriter outputString = new StreamWriter(
                File.Open("Computer.txt", FileMode.Create)))
            {
                //Write strings to File
                outputString.WriteLine("ProductID: " + ProductIDTextLabel.Text);
                outputString.WriteLine("Manufacturer: " + ManufacturerTextLabel.Text);
                outputString.WriteLine(ModelTextLabel);
                outputString.WriteLine(MemoryTextLabel);
                outputString.WriteLine(LCDSizeTextLabel);
                outputString.WriteLine(CPUBrandTextLabel);
                outputString.WriteLine(CPUTypeTextLabel);

                // close 
                outputString.Close();
                outputString.Dispose();
            }

            MessageBox.Show("File Saved Succesfully!", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
