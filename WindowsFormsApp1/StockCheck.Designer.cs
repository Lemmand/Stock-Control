namespace WindowsFormsApp1
{
    partial class StockCheck
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryManagmentSystemDataSet = new WindowsFormsApp1.InventoryManagmentSystemDataSet();
            this.tbl_itemsTableAdapter = new WindowsFormsApp1.InventoryManagmentSystemDataSetTableAdapters.tbl_itemsTableAdapter();
            this.quantityCheckToolStrip = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagmentSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.prodquantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblitemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(181, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(343, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // prodidDataGridViewTextBoxColumn
            // 
            this.prodidDataGridViewTextBoxColumn.DataPropertyName = "prod_id";
            this.prodidDataGridViewTextBoxColumn.HeaderText = "prod_id";
            this.prodidDataGridViewTextBoxColumn.Name = "prodidDataGridViewTextBoxColumn";
            this.prodidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            this.prodnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodquantityDataGridViewTextBoxColumn
            // 
            this.prodquantityDataGridViewTextBoxColumn.DataPropertyName = "prod_quantity";
            this.prodquantityDataGridViewTextBoxColumn.HeaderText = "prod_quantity";
            this.prodquantityDataGridViewTextBoxColumn.Name = "prodquantityDataGridViewTextBoxColumn";
            this.prodquantityDataGridViewTextBoxColumn.ReadOnly = true;
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
            // quantityCheckToolStrip
            // 
            this.quantityCheckToolStrip.Location = new System.Drawing.Point(0, 0);
            this.quantityCheckToolStrip.Name = "quantityCheckToolStrip";
            this.quantityCheckToolStrip.Size = new System.Drawing.Size(800, 25);
            this.quantityCheckToolStrip.TabIndex = 1;
            this.quantityCheckToolStrip.Text = "quantityCheckToolStrip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Low Stock List (Under 20 In Quantity)";
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warning.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_warning.Location = new System.Drawing.Point(540, 198);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(0, 25);
            this.lbl_warning.TabIndex = 4;
            // 
            // StockCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityCheckToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StockCheck";
            this.Text = "StockCheck";
            this.Load += new System.EventHandler(this.StockCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagmentSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private InventoryManagmentSystemDataSet inventoryManagmentSystemDataSet;
        private System.Windows.Forms.BindingSource tblitemsBindingSource;
        private InventoryManagmentSystemDataSetTableAdapters.tbl_itemsTableAdapter tbl_itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip quantityCheckToolStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_warning;
    }
}