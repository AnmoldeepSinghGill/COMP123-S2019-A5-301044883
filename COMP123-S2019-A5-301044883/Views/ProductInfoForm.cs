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

/*
 * Author: Anmoldeep Singh Gill
 * Student ID: 301044883
 * Created on: 31 July 2019
 * Description: This Form shows all the Product info
 *              in labels that the customer has selected in the 
 *              Select Form or have opened an order from a file.
 */

namespace COMP123_S2019_A5_301044883.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is an event Handler for Select Another Product 
        /// Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method is used to open the saved order from 
        /// the existing file
        /// 
        /// Method of Opening files refrenced from Professor Tom Tsiliopoulus's 
        /// Saving and Loading Files Code
        /// </summary>
        public void OpenSavedOrder()
        {
            //configure save file dialog box
            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

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
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();

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

        /// <summary>
        /// This is an event handler for Save Button on tool Strip Menu
        /// and this saves the current order details in a text file.
        /// 
        /// Method of Savaing files refrenced from Professor Tom Tsiliopoulus's 
        /// Saving and Loading Files Code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure save file dialog box
            ProductSaveFileDialog.FileName = "Product.txt";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            //Open Svae File Dialog
            var ShowDialog = ProductSaveFileDialog.ShowDialog();

            if (ShowDialog != DialogResult.Cancel)
            {
                //open Sterem Writer to write
                using (StreamWriter outputString = new StreamWriter(
                    File.Open(ProductSaveFileDialog.FileName, FileMode.Create)))
                {
                    //Write strings to File
                    outputString.WriteLine(Program.product.productID.ToString());
                    outputString.WriteLine(Program.product.manufacturer);
                    outputString.WriteLine(Program.product.model);
                    outputString.WriteLine(Program.product.cost.ToString());
                    outputString.WriteLine(Program.product.condition);
                    outputString.WriteLine(Program.product.platform);
                    outputString.WriteLine(Program.product.RAM_size);
                    outputString.WriteLine(Program.product.screensize);
                    outputString.WriteLine(Program.product.CPU_brand);
                    outputString.WriteLine(Program.product.CPU_type);
                    outputString.WriteLine(Program.product.CPU_number);
                    outputString.WriteLine(Program.product.CPU_speed);
                    outputString.WriteLine(Program.product.screensize);
                    outputString.WriteLine(Program.product.HDD_size);
                    outputString.WriteLine(Program.product.GPU_Type);
                    outputString.WriteLine(Program.product.webcam);
                    outputString.WriteLine(Program.product.OS);

                    // close 
                    outputString.Close();
                    outputString.Dispose();
                }

                MessageBox.Show("File Saved Succesfully!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// This is an event handler for the Form closing event 
        /// for Product Info Form
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method populates the labels on the form when 
        /// it is activated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            //Assigns the value from properties to respective textboxes
            ProductIDTextLabel.Text = Program.product.productID.ToString();
            ManufacturerTextLabel.Text = Program.product.manufacturer;
            ModelTextLabel.Text = Program.product.model;
            CostTextLabel.Text = String.Format("{0:C}", Program.product.cost);
            ConditionTextLabel.Text = Program.product.condition;
            PlatformTextLabel.Text = Program.product.platform;
            MemoryTextLabel.Text = Program.product.RAM_size;
            LCDSizeTextLabel.Text = Program.product.screensize;
            CPUBrandTextLabel.Text = Program.product.CPU_brand;
            CPUTypeTextLabel.Text = Program.product.CPU_type;
            CPUNumberTextLabel.Text = Program.product.CPU_number;
            CPUSpeedTextLabel.Text = Program.product.CPU_speed;
            LCDSizeTextLabel.Text = Program.product.screensize;
            HDDTextLabel.Text = Program.product.HDD_size;
            GPUTypeTextLabel.Text = Program.product.GPU_Type;
            WebCamTextLabel.Text = Program.product.webcam;
            OSTextLabel.Text = Program.product.OS;
        }

        /// <summary>
        /// This is an event handler for Open Button on tool Strip Menu
        /// and opens the saved order details from text file.
        /// 
        /// Method of Opening files refrenced from Professor Tom Tsiliopoulus's 
        /// Saving and Loading Files Code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure save file dialog box
            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

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
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();

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
    }
}