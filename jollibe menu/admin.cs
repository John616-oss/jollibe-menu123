using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jollibe_menu
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Product";
            dataGridView1.Columns[2].Name = "Price";
            dataGridView1.Columns[3].Name = "Category";
            dataGridView1.Columns[4].Name = "Quantity";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string product = txtProduct.Text;
            string price = txtPrice.Text;
            string category = txtCategory.Text;
            string quantity = txtQuantity.Text;

            if (id == "" || product == "" || price == "" || category == "" || quantity == "" )
            {
                               MessageBox.Show("Please fill in all fields.");
                return;
            }
            dataGridView1.Rows.Add(id, product, price, category, quantity);

            txtID.Clear();
            txtProduct.Clear();
            txtPrice.Clear();
            txtCategory.Clear();
            txtQuantity.Clear();
        }
    }
}
