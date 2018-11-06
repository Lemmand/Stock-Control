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
    public partial class AddItem : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-7P495QJ\SQLEXPRESS;Initial Catalog=InventoryManagmentSystem;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter datapt;
        public AddItem()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            
            sqlcon.Open();
            cmd = new SqlCommand("INSERT INTO tbl_items (prod_name,prod_quantity) VALUES (@prod_name,@prod_quantity)", sqlcon);
           
            cmd.Parameters.AddWithValue("@prod_name",txt_name.Text);
            cmd.Parameters.AddWithValue("@prod_quantity", txt_quantity.Text);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            txt_name.Text = "";
            txt_quantity.Text = "";
        }
    }
}
