using COMP123_S2019_A5_301044883.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure save file dialog box
            ProductSaveFileDialog.FileName = "Product.txt";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Text Files (*.txt)|*.txt | All Files (*.*)|*.*";

            //Open Svae File Dialog
            var ShowDialog = ProductSaveFileDialog.ShowDialog();

            if (ShowDialog != DialogResult.Cancel)
            {
                //open Sterem Writer to write
                using (StreamWriter outputString = new StreamWriter(
                    File.Open("Product.txt", FileMode.Create)))
                {
                    //Write strings to File
                    outputString.WriteLine(Program.product.productID.ToString());
                    outputString.WriteLine(Program.product.manufacturer);
                    outputString.WriteLine(Program.product.model);
                    outputString.WriteLine(Program.product.RAM_size);
                    outputString.WriteLine(Program.product.screensize);
                    outputString.WriteLine(Program.product.CPU_brand);
                    outputString.WriteLine(Program.product.CPU_type);

                    // close 
                    outputString.Close();
                    outputString.Dispose();
                }

                MessageBox.Show("File Saved Succesfully!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void OpenSavedOrder()
        {
            //configure save file dialog box
            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text Files (*.txt)|*.txt | All Files (*.*)|*.*";

            //Open Svae File Dialog
            var ShowDialog = ProductOpenFileDialog.ShowDialog();
            if (ShowDialog != DialogResult.Cancel)
            {
                try
                {
                    //open Sterem Writer to write
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //Write strings to File
                        //Program.product.productID = short.Parse(inputString.ReadLine());
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();

                        // close 
                        inputStream.Close();
                        inputStream.Dispose();
                    }

                    MessageBox.Show("File Retrieved Succesfully!", "Opened",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
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
    }
}