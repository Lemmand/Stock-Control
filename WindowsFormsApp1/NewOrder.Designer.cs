namespace WindowsFormsApp1
{
    partial class NewOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_createorder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblorderlineBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryManagmentSystemDataSet1 = new WindowsFormsApp1.InventoryManagmentSystemDataSet1();
            this.txt_orderid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodsupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryManagmentSystemDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryManagmentSystemDataSet = new WindowsFormsApp1.InventoryManagmentSystemDataSet();
            this.inventoryManagmentSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_addtoorder = new System.Windows.Forms.Button();
            this.tblorderlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_order_lineTableAdapter = new WindowsFormsApp1.InventoryManagmentSystemDataSet1TableAdapters.tbl_order_lineTableAdapter();
            this.tbl_itemsTableAdapter = new WindowsFormsApp1.InventoryManagmentSystemDataSet1TableAdapters.tbl_itemsTableAdapter();
            this.tbl_orderTableAdapter = new WindowsFormsApp1.InventoryManagmentSystemDataSet1TableAdapters.tbl_orderTableAdapter();
            this.tblorderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderlineBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagmentSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagmentSystemDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagmentSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagmentSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderlineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_createorder
            // 
            this.btn_createorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createorder.Location = new System.Drawing.Point(331, 47);
            this.btn_createorder.Name = "btn_createorder";
            this.btn_createorder.Size = new System.Drawing.Size(127, 58);
            this.btn_createorder.TabIndex = 0;
            this.btn_createorder.Text = "Create Order";
            this.btn_createorder.UseVisualStyleBackColor = true;
            this.btn_createorder.Click += new System.EventHandler(this.btn_createorder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.orderlineDataGridViewTextBoxColumn,
            this.orderprodDataGridViewTextBoxColumn,
            this.orderquantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblorderlineBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(972, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(446, 279);
            this.dataGridView1.TabIndex = 4;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "Order ID";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderlineDataGridViewTextBoxColumn
            // 
            this.orderlineDataGridViewTextBoxColumn.DataPropertyName = "order_line";
            this.orderlineDataGridViewTextBoxColumn.HeaderText = "Order Line";
            this.orderlineDataGridViewTextBoxColumn.Name = "orderlineDataGridViewTextBoxColumn";
            this.orderlineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderprodDataGridViewTextBoxColumn
            // 
            this.orderprodDataGridViewTextBoxColumn.DataPropertyName = "order_prod";
            this.orderprodDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.orderprodDataGridViewTextBoxColumn.Name = "orderprodDataGridViewTextBoxColumn";
            this.orderprodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderquantityDataGridViewTextBoxColumn
            // 
            this.orderquantityDataGridViewTextBoxColumn.DataPropertyName = "order_quantity";
            this.orderquantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.orderquantityDataGridViewTextBoxColumn.Name = "orderquantityDataGridViewTextBoxColumn";
            this.orderquantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblorderlineBindingSource1
            // 
            this.tblorderlineBindingSource1.DataMember = "tbl_order_line";
            this.tblorderlineBindingSource1.DataSource = this.inventoryManagmentSystemDataSet1;
            // 
            // inventoryManagmentSystemDataSet1
            // 
            this.inventoryManagmentSystemDataSet1.DataSetName = "InventoryManagmentSystemDataSet1";
            this.inventoryManagmentSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_orderid
            // 
            this.txt_orderid.Location = new System.Drawing.Point(220, 180);
            this.txt_orderid.Name = "txt_orderid";
            this.txt_orderid.Size = new System.Drawing.Size(156, 20);
            this.txt_orderid.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.prodquantityDataGridViewTextBoxColumn,
            this.prodsupplierDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblitemsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(520, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(446, 279);
            this.dataGridView2.TabIndex = 9;
            // 
            // prodidDataGridViewTextBoxColumn
            // 
            this.prodidDataGridViewTextBoxColumn.DataPropertyName = "prod_id";
            this.prodidDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.prodidDataGridViewTextBoxColumn.Name = "prodidDataGridViewTextBoxColumn";
            this.prodidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            this.prodnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodquantityDataGridViewTextBoxColumn
            // 
            this.prodquantityDataGridViewTextBoxColumn.DataPropertyName = "prod_quantity";
            this.prodquantityDataGridViewTextBoxColumn.HeaderText = "Quantity In Stock";
            this.prodquantityDataGridViewTextBoxColumn.Name = "prodquantityDataGridViewTextBoxColumn";
            this.prodquantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodsupplierDataGridViewTextBoxColumn
            // 
            this.prodsupplierDataGridViewTextBoxColumn.DataPropertyName = "prod_supplier";
            this.prodsupplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.prodsupplierDataGridViewTextBoxColumn.Name = "prodsupplierDataGridViewTextBoxColumn";
            this.prodsupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblitemsBindingSource
            // 
            this.tblitemsBindingSource.DataMember = "tbl_items";
            this.tblitemsBindingSource.DataSource = this.inventoryManagmentSystemDataSet1;
            // 
            // tblorderBindingSource
            // 
            this.tblorderBindingSource.DataMember = "tbl_order";
            this.tblorderBindingSource.DataSource = this.inventoryManagmentSystemDataSet1BindingSource;
            // 
            // inventoryManagmentSystemDataSet1BindingSource
            // 
            this.inventoryManagmentSystemDataSet1BindingSource.DataSource = this.inventoryManagmentSystemDataSet1;
            this.inventoryManagmentSystemDataSet1BindingSource.Position = 0;
            // 
            // inventoryManagmentSystemDataSet
            // 
            this.inventoryManagmentSystemDataSet.DataSetName = "InventoryManagmentSystemDataSet";
            this.inventoryManagmentSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryManagmentSystemDataSetBindingSource
            // 
            this.inventoryManagmentSystemDataSetBindingSource.DataSource = this.inventoryManagmentSystemDataSet;
            this.inventoryManagmentSystemDataSetBindingSource.Position = 0;
            // 
            // txt_addtoorder
            // 
            this.txt_addtoorder.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_addtoorder.Location = new System.Drawing.Point(220, 215);
            this.txt_addtoorder.Name = "txt_addtoorder";
            this.txt_addtoorder.Size = new System.Drawing.Size(156, 58);
            this.txt_addtoorder.TabIndex = 11;
            this.txt_addtoorder.Text = "Add To Order";
            this.txt_addtoorder.UseVisualStyleBackColor = true;
            this.txt_addtoorder.Click += new System.EventHandler(this.txt_addtoorder_Click);
            // 
            // tblorderlineBindingSource
            // 
            this.tblorderlineBindingSource.DataMember = "tbl_order_line";
            this.tblorderlineBindingSource.DataSource = this.inventoryManagmentSystemDataSet1;
            // 
            // tbl_order_lineTableAdapter
            // 
            this.tbl_order_lineTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_itemsTableAdapter
            // 
            this.tbl_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_orderTableAdapter
            // 
            this.tbl_orderTableAdapter.ClearBeforeFill = true;
            // 
            // tblorderBindingSource1
            // 
            this.tblorderBindingSource1.DataMember = "tbl_order";
            this.tblorderBindingSource1.DataSource = this.inventoryManagmentSystemDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "*Select A Row From The Product List and Then Fill the Quantity Field";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(185, 66);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(100, 20);
            this.txt_date.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Enter Order Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Format (YYYY,MM,DD)";
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 625);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_addtoorder);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_orderid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_createorder);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderlineBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagmentSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagmentSystemDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagmentSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagmentSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderlineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createorder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_orderid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private InventoryManagmentSystemDataSet1 inventoryManagmentSystemDataSet1;
        private System.Windows.Forms.BindingSource tblorderlineBindingSource;
        private InventoryManagmentSystemDataSet1TableAdapters.tbl_order_lineTableAdapter tbl_order_lineTableAdapter;
        private System.Windows.Forms.BindingSource tblitemsBindingSource;
        private InventoryManagmentSystemDataSet1TableAdapters.tbl_itemsTableAdapter tbl_itemsTableAdapter;
        private System.Windows.Forms.BindingSource tblorderlineBindingSource1;
        private System.Windows.Forms.BindingSource inventoryManagmentSystemDataSet1BindingSource;
        private System.Windows.Forms.BindingSource tblorderBindingSource;
        private InventoryManagmentSystemDataSet1TableAdapters.tbl_orderTableAdapter tbl_orderTableAdapter;
        private InventoryManagmentSystemDataSet inventoryManagmentSystemDataSet;
        private System.Windows.Forms.BindingSource inventoryManagmentSystemDataSetBindingSource;
        private System.Windows.Forms.Button txt_addtoorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodsupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblorderBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}