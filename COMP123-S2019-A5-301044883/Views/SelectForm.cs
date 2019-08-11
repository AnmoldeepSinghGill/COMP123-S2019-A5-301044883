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

namespace COMP123_S2019_A5_301044883.Views
{
    public partial class SelectForm : Form
    {
        public string OutputString { get; set; }
        public string Manufacturer { get; set; }

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
            var cost = currentRow.Cells[1].Value.ToString();

            OutputString = manufacturer + " " + model + " " +  "$" + cost;

            HardwareListLabel.Text = OutputString;
            Manufacturer = manufacturer;

            Program.product.model = currentRow.Cells[3].Value.ToString();
            Program.product.productID = short.Parse(currentRow.Cells[0].Value.ToString());
            Program.product.cost = decimal.Parse(currentRow.Cells[1].Value.ToString());
            Program.product.manufacturer = currentRow.Cells[2].Value.ToString();
            Program.product.model = currentRow.Cells[3].Value.ToString();
            Program.product.RAM_size = currentRow.Cells[5].Value.ToString();
            Program.product.screensize = currentRow.Cells[7].Value.ToString();
            Program.product.CPU_brand = currentRow.Cells[10].Value.ToString();
            Program.product.CPU_type = currentRow.Cells[9].Value.ToString();
        }
    }
}
