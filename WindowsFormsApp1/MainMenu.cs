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
    public partial class MainMenu : Form
    {

       

            public MainMenu()
        {
            Login login = new Login();
            Application.Run(login);
            InitializeComponent();
        }


        private void MainMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem form6 = new AddItem();
            form6.MdiParent = this;
            form6.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            interactivereport form3 = new interactivereport();
            form3.MdiParent = this;
            form3.Show();
        }

        private void checkStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockCheck form4 = new StockCheck();
            form4.MdiParent = this;
            form4.Show();
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewOrder form5 = new NewOrder();
            form5.MdiParent = this;
            form5.Show();
        }
    }
}
