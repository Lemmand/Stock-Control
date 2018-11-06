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
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class StockCheck : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-7P495QJ\SQLEXPRESS;Initial Catalog=InventoryManagmentSystem;Integrated Security=True");

        SqlDataAdapter sqlData;
        public StockCheck()
        {
            InitializeComponent();
        }
        private void StockCheck_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryManagmentSystemDataSet.tbl_items' table. You can move, or remove it, as needed.
            this.tbl_itemsTableAdapter.Fill(this.inventoryManagmentSystemDataSet.tbl_items);
            this.tbl_itemsTableAdapter.QuantityCheck(this.inventoryManagmentSystemDataSet.tbl_items);
            if(this.tbl_itemsTableAdapter.QuantityCheck(this.inventoryManagmentSystemDataSet.tbl_items) > 0)
                {
                     lbl_warning.Text = "Need to Restock";

            }
           

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_itemsTableAdapter.FillBy(this.inventoryManagmentSystemDataSet.tbl_items);
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            string createText = "Hello and Welcome" + Environment.NewLine;
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\purchaseorder.txt",createText);
        }
    }
}
