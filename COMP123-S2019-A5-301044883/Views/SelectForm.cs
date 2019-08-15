using COMP123_S2019_A5_301044883.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Anmoldeep Singh Gill
 * Student ID: 301044883
 * Created on: 31 July 2019
 * Description: This Form includes a DataGridview
 *              which displays data about the computers
 *              and from which the customer could select.
 */

namespace COMP123_S2019_A5_301044883.Views
{
    public partial class SelectForm : Form
    {
        public string OutputString { get; set; }

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductDataGridView.Rows[rowIndex];
            var manufacturer = currentRow.Cells[2].Value.ToString();
            var model = currentRow.Cells[3].Value.ToString();
            var cost = currentRow.Cells[1].Value;

            OutputString = manufacturer + " " + model + " " + String.Format("{0:C}", cost);

            HardwareListLabel.Text = OutputString;

            Program.product.productID = short.Parse(currentRow.Cells[0].Value.ToString());
            Program.product.cost = decimal.Parse(currentRow.Cells[1].Value.ToString());
            Program.product.manufacturer = currentRow.Cells[2].Value.ToString();
            Program.product.model = currentRow.Cells[3].Value.ToString();
            Program.product.RAM_type = currentRow.Cells[4].Value.ToString();
            Program.product.RAM_size = currentRow.Cells[5].Value.ToString();
            Program.product.displaytype = currentRow.Cells[6].Value.ToString();
            Program.product.screensize = currentRow.Cells[7].Value.ToString();
            Program.product.resolution = currentRow.Cells[8].Value.ToString();
            Program.product.CPU_Class = currentRow.Cells[9].Value.ToString();
            Program.product.CPU_brand = currentRow.Cells[10].Value.ToString();
            Program.product.CPU_type = currentRow.Cells[11].Value.ToString();
            Program.product.CPU_speed = currentRow.Cells[12].Value.ToString();
            Program.product.CPU_number = currentRow.Cells[13].Value.ToString();
            Program.product.condition = currentRow.Cells[14].Value.ToString();
            Program.product.OS = currentRow.Cells[15].Value.ToString();
            Program.product.platform = currentRow.Cells[16].Value.ToString();
            Program.product.HDD_speed = currentRow.Cells[17].Value.ToString();
            Program.product.HDD_size = currentRow.Cells[18].Value.ToString();
            Program.product.GPU_Type = currentRow.Cells[19].Value.ToString();
            Program.product.optical_drive = currentRow.Cells[20].Value.ToString();
            Program.product.Audio_type = currentRow.Cells[21].Value.ToString();
            Program.product.LAN = currentRow.Cells[22].Value.ToString();
            Program.product.WIFI = currentRow.Cells[23].Value.ToString();
            Program.product.width = currentRow.Cells[24].Value.ToString();
            Program.product.height = currentRow.Cells[25].Value.ToString();
            Program.product.depth = currentRow.Cells[26].Value.ToString();
            Program.product.weight = currentRow.Cells[27].Value.ToString();
            Program.product.moust_type = currentRow.Cells[28].Value.ToString();
            Program.product.power = currentRow.Cells[29].Value.ToString();
            Program.product.webcam = currentRow.Cells[30].Value.ToString();
        }
    }
}
