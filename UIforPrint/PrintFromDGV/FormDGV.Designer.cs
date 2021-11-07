namespace UIforPrint.PrintFromDGV
{
    partial class FormDGFormExperimentalPrint
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
            this.dataGridViewMaterials = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDataSetMaterials = new UIforPrint.OrdersDataSet();
            this.materialsTableAdapter = new UIforPrint.OrdersDataSetTableAdapters.MaterialsTableAdapter();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSetMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMaterials
            // 
            this.dataGridViewMaterials.AllowUserToOrderColumns = true;
            this.dataGridViewMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewMaterials.AutoGenerateColumns = false;
            this.dataGridViewMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMaterials.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.materialsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn});
            this.dataGridViewMaterials.DataSource = this.materialsBindingSource;
            this.dataGridViewMaterials.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaterials.Name = "dataGridViewMaterials";
            this.dataGridViewMaterials.Size = new System.Drawing.Size(709, 450);
            this.dataGridViewMaterials.TabIndex = 0;
            this.dataGridViewMaterials.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewMaterials_KeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 66;
            // 
            // materialsDataGridViewTextBoxColumn
            // 
            this.materialsDataGridViewTextBoxColumn.DataPropertyName = "Materials";
            this.materialsDataGridViewTextBoxColumn.HeaderText = "Материалы";
            this.materialsDataGridViewTextBoxColumn.Name = "materialsDataGridViewTextBoxColumn";
            this.materialsDataGridViewTextBoxColumn.Width = 90;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 91;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена за еденицу";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 107;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.Width = 96;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.ordersDataSetMaterials;
            // 
            // ordersDataSetMaterials
            // 
            this.ordersDataSetMaterials.DataSetName = "OrdersDataSet";
            this.ordersDataSetMaterials.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.AccessibleDescription = "";
            this.buttonPrint.AccessibleName = "";
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonPrint.Location = new System.Drawing.Point(727, 12);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(61, 23);
            this.buttonPrint.TabIndex = 1;
            this.buttonPrint.Tag = "";
            this.buttonPrint.Text = "&Print";
            this.buttonPrint.UseMnemonic = false;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(727, 41);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 24);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormDGFormExperimentalPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewMaterials);
            this.Name = "FormDGFormExperimentalPrint";
            this.Text = "Form Data Grid View";
            this.Load += new System.EventHandler(this.FormDGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSetMaterials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private OrdersDataSet ordersDataSetMaterials;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private OrdersDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.DataGridView dataGridViewMaterials;
    }
}