namespace UIforPrint.FoxLean
{
    partial class FormFoxLean
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonPrewPage = new System.Windows.Forms.Button();
            this.labelNumberOfPage = new System.Windows.Forms.Label();
            this.ordersDataSet = new UIforPrint.OrdersDataSet();
            this.ordersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new UIforPrint.OrdersDataSetTableAdapters.MaterialsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.materialsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materialsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.Location = new System.Drawing.Point(654, 381);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(61, 25);
            this.buttonPrint.TabIndex = 1;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextPage.Location = new System.Drawing.Point(624, 381);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(24, 25);
            this.buttonNextPage.TabIndex = 2;
            this.buttonNextPage.Text = ">";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // buttonPrewPage
            // 
            this.buttonPrewPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrewPage.Location = new System.Drawing.Point(532, 381);
            this.buttonPrewPage.Name = "buttonPrewPage";
            this.buttonPrewPage.Size = new System.Drawing.Size(24, 25);
            this.buttonPrewPage.TabIndex = 3;
            this.buttonPrewPage.Text = "<";
            this.buttonPrewPage.UseVisualStyleBackColor = true;
            this.buttonPrewPage.Click += new System.EventHandler(this.buttonPrewPage_Click);
            // 
            // labelNumberOfPage
            // 
            this.labelNumberOfPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberOfPage.AutoSize = true;
            this.labelNumberOfPage.Location = new System.Drawing.Point(562, 387);
            this.labelNumberOfPage.Name = "labelNumberOfPage";
            this.labelNumberOfPage.Size = new System.Drawing.Size(46, 13);
            this.labelNumberOfPage.TabIndex = 4;
            this.labelNumberOfPage.Text = "Page {} ";
            // 
            // ordersDataSet
            // 
            this.ordersDataSet.DataSetName = "OrdersDataSet";
            this.ordersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersDataSetBindingSource
            // 
            this.ordersDataSetBindingSource.DataSource = this.ordersDataSet;
            this.ordersDataSetBindingSource.Position = 0;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.ordersDataSetBindingSource;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialsDataGridViewTextBoxColumn
            // 
            this.materialsDataGridViewTextBoxColumn.DataPropertyName = "Materials";
            this.materialsDataGridViewTextBoxColumn.HeaderText = "Materials";
            this.materialsDataGridViewTextBoxColumn.Name = "materialsDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // FormFoxLean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 415);
            this.Controls.Add(this.labelNumberOfPage);
            this.Controls.Add(this.buttonPrewPage);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormFoxLean";
            this.Text = "FormFoxLean";
            this.Load += new System.EventHandler(this.FormFoxLean_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ordersDataSetBindingSource;
        private OrdersDataSet ordersDataSet;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonPrewPage;
        private System.Windows.Forms.Label labelNumberOfPage;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private OrdersDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
    }
}