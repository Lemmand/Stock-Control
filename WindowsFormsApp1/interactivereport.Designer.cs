namespace WindowsFormsApp1
{
    partial class interactivereport
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
            this.btn_getstock = new System.Windows.Forms.Button();
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryManagmentSystemDataSet = new WindowsFormsApp1.InventoryManagmentSystemDataSet();
            this.tbl_itemsTableAdapter = new WindowsFormsApp1.InventoryManagmentSystemDataSetTableAdapters.tbl_itemsTableAdapter();
            this.searchNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.lblname = new System.Windows.Forms.Label();
            this.txtnames = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagmentSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_getstock
            // 
            this.btn_getstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getstock.Location = new System.Drawing.Point(562, 156);
            this.btn_getstock.Name = "btn_getstock";
            this.btn_getstock.Size = new System.Drawing.Size(152, 44);
            this.btn_getstock.TabIndex = 1;
            this.btn_getstock.Text = "Get Stock";
            this.btn_getstock.UseVisualStyleBackColor = true;
            this.btn_getstock.Click += new System.EventHandler(this.btn_getstock_Click);
            // 
            // dgv_items
            // 
            this.dgv_items.AllowUserToAddRows = false;
            this.dgv_items.AllowUserToDeleteRows = false;
            this.dgv_items.AutoGenerateColumns = false;
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.prodquantityDataGridViewTextBoxColumn});
            this.dgv_items.DataSource = this.tblitemsBindingSource;
            this.dgv_items.Location = new System.Drawing.Point(12, 28);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.Size = new System.Drawing.Size(343, 405);
            this.dgv_items.TabIndex = 2;
            this.dgv_items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prodidDataGridViewTextBoxColumn
            // 
            this.prodidDataGridViewTextBoxColumn.DataPropertyName = "prod_id";
            this.prodidDataGridViewTextBoxColumn.HeaderText = "prod_id";
            this.prodidDataGridViewTextBoxColumn.Name = "prodidDataGridViewTextBoxColumn";
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            // 
            // prodquantityDataGridViewTextBoxColumn
            // 
            this.prodquantityDataGridViewTextBoxColumn.DataPropertyName = "prod_quantity";
            this.prodquantityDataGridViewTextBoxColumn.HeaderText = "prod_quantity";
            this.prodquantityDataGridViewTextBoxColumn.Name = "prodquantityDataGridViewTextBoxColumn";
            // 
            // tblitemsBindingSource
            // 
            this.tblitemsBindingSource.DataMember = "tbl_items";
            this.tblitemsBindingSource.DataSource = this.inventoryManagmentSystemDataSet;
            // 
            // inventoryManagmentSystemDataSet
            // 
            this.inventoryManagmentSystemDataSet.DataSetName = "InventoryManagmentSystemDataSet";
            this.inventoryManagmentSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_itemsTableAdapter
            // 
            this.tbl_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // searchNameToolStrip
            // 
            this.searchNameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchNameToolStrip.Name = "searchNameToolStrip";
            this.searchNameToolStrip.Size = new System.Drawing.Size(800, 25);
            this.searchNameToolStrip.TabIndex = 3;
            this.searchNameToolStrip.Text = "searchNameToolStrip";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(548, 52);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(166, 24);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Search By Name";
            // 
            // txtnames
            // 
            this.txtnames.Location = new System.Drawing.Point(556, 105);
            this.txtnames.Name = "txtnames";
            this.txtnames.Size = new System.Drawing.Size(157, 20);
            this.txtnames.TabIndex = 5;
            this.txtnames.TextChanged += new System.EventHandler(this.txtnames_TextChanged);
            // 
            // interactivereport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnames);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.searchNameToolStrip);
            this.Controls.Add(this.dgv_items);
            this.Controls.Add(this.btn_getstock);
            this.Name = "interactivereport";
            this.Text = "interactivereport";
            this.Load += new System.EventHandler(this.interactivereport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagmentSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_getstock;
        private System.Windows.Forms.DataGridView dgv_items;
        private InventoryManagmentSystemDataSet inventoryManagmentSystemDataSet;
        private System.Windows.Forms.BindingSource tblitemsBindingSource;
        private InventoryManagmentSystemDataSetTableAdapters.tbl_itemsTableAdapter tbl_itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip searchNameToolStrip;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtnames;
    }
}