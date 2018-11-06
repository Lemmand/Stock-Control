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
    public partial class NewOrder : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A9R1KT2\SQLEXPRESS;Initial Catalog=InventoryManagmentSystem;Integrated Security=True");
        SqlCommand createneworder,additemstoorder,getlastorder;
        SqlDataAdapter datapter = new SqlDataAdapter("SELECT * FROM tbl_items", con);
        DataTable dt = new DataTable();
        SqlDataReader myreader = null;
        int numbertocount = 0;
        decimal msg;
        int showcount = 0;

        public NewOrder()
        {
            InitializeComponent();
        }

        private void btn_createorder_Click(object sender, EventArgs e)
        {
            con.Open();

            getlastorder = new SqlCommand("SELECT TOP 1 * FROM tbl_order ORDER BY order_id DESC", con);
            getlastorder.ExecuteNonQuery();
            myreader = getlastorder.ExecuteReader();

            while (myreader.Read())
            {
                msg = Convert.ToInt32(myreader[0]);
                msg = msg + 1;
            }
            myreader.Close();

            createneworder = new SqlCommand("INSERT INTO tbl_order (order_date) VALUES (@order_date)", con);
            if (string.IsNullOrEmpty(txt_date.Text))
            {
                MessageBox.Show("Enter Date");
            } else { showcount = 1; }

            createneworder.Parameters.AddWithValue("@order_date", txt_date.Text);

            createneworder.ExecuteNonQuery();
            dataGridView1.Update();
            dataGridView1.Refresh();
            con.Close();

            if (showcount == 1)
            {
                txt_addtoorder.Show();
                dataGridView1.Show();
                dataGridView2.Show();
                label1.Show();
                label2.Show();
                txt_orderid.Show();

                refreshdata();
            }

        }

        private void txt_addtoorder_Click(object sender, EventArgs e)
        {
            con.Open();
            additemstoorder = new SqlCommand("INSERT INTO tbl_order_line (order_id,order_line,order_prod,order_quantity) VALUES (@order_id,@order_line,@order_prod,@order_quantity)", con);

 
            string getid = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            var vgetid = getid;


            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                additemstoorder.Parameters.AddWithValue("@order_id", msg);
                additemstoorder.Parameters.AddWithValue("@order_prod", vgetid);
                additemstoorder.Parameters.AddWithValue("@order_line", numbertocount);
                if (string.IsNullOrEmpty(txt_orderid.Text))
                {
                    MessageBox.Show("Enter Quantity");
                }

                    additemstoorder.Parameters.AddWithValue("@order_quantity", txt_orderid.Text);

            }
            numbertocount++;
            additemstoorder.ExecuteNonQuery();
           
            con.Close();
            refreshdata();
            

        }

        private void refreshdata()
        {
            this.tbl_order_lineTableAdapter.FillBy2(this.inventoryManagmentSystemDataSet1.tbl_order_line);
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryManagmentSystemDataSet1.tbl_items' table. You can move, or remove it, as needed.
            this.tbl_itemsTableAdapter.Fill(this.inventoryManagmentSystemDataSet1.tbl_items);
            
            // TODO: This line of code loads data into the 'inventoryManagmentSystemDataSet1.tbl_order_line' table. You can move, or remove it, as needed.
            this.tbl_order_lineTableAdapter.FillBy2(this.inventoryManagmentSystemDataSet1.tbl_order_line);

            txt_addtoorder.Hide();
            dataGridView1.Hide();
            dataGridView2.Hide();
            label1.Hide();
            label2.Hide();
            txt_orderid.Hide();

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            
            

        }
    }
}
