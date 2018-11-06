using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class interactivereport : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-A9R1KT2\SQLEXPRESS;Initial Catalog=InventoryManagmentSystem;Integrated Security=True");
        SqlCommand cmd2;
        SqlDataAdapter datapt;
        public interactivereport()
        {
            InitializeComponent();
        }

        private void btn_getstock_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_itemsTableAdapter.SearchName(this.inventoryManagmentSystemDataSet.tbl_items, txtnames.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void interactivereport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryManagmentSystemDataSet.tbl_items' table. You can move, or remove it, as needed.
            this.tbl_itemsTableAdapter.Fill(this.inventoryManagmentSystemDataSet.tbl_items);

        }

        private void txtnames_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
