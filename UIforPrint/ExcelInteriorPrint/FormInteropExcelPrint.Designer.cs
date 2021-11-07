namespace UIforPrint.ExcelInteriorPrint
{
    partial class FormInteropExcelPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInteropExcelPrint));
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersdbDSOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersdbDSOrders = new UIforPrint.usersdbDSOrders();
            this.ordersTableAdapter = new UIforPrint.usersdbDSOrdersTableAdapters.OrdersTableAdapter();
            this.toolStripFormInteropPrint = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDSOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDSOrders)).BeginInit();
            this.toolStripFormInteropPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.usersdbDSOrdersBindingSource;
            // 
            // usersdbDSOrdersBindingSource
            // 
            this.usersdbDSOrdersBindingSource.DataSource = this.usersdbDSOrders;
            this.usersdbDSOrdersBindingSource.Position = 0;
            // 
            // usersdbDSOrders
            // 
            this.usersdbDSOrders.DataSetName = "usersdbDSOrders";
            this.usersdbDSOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripFormInteropPrint
            // 
            this.toolStripFormInteropPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCancel,
            this.toolStripSeparator1,
            this.toolStripButtonPrint});
            this.toolStripFormInteropPrint.Location = new System.Drawing.Point(0, 0);
            this.toolStripFormInteropPrint.Name = "toolStripFormInteropPrint";
            this.toolStripFormInteropPrint.Size = new System.Drawing.Size(519, 25);
            this.toolStripFormInteropPrint.TabIndex = 1;
            this.toolStripFormInteropPrint.Text = "toolStrip1";
            // 
            // toolStripButtonCancel
            // 
            this.toolStripButtonCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancel.Image")));
            this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancel.Name = "toolStripButtonCancel";
            this.toolStripButtonCancel.Size = new System.Drawing.Size(47, 22);
            this.toolStripButtonCancel.Text = "Cancel";
            this.toolStripButtonCancel.Click += new System.EventHandler(this.toolStripButtonCancel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(36, 22);
            this.toolStripButtonPrint.Text = "Print";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToOrderColumns = true;
            this.dataGridViewOrders.AutoGenerateColumns = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.dataGridViewOrders.DataSource = this.ordersBindingSource;
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(519, 378);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewOrders_KeyDown);
            // 
            // FormInteropExcelPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 407);
            this.Controls.Add(this.toolStripFormInteropPrint);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "FormInteropExcelPrint";
            this.Text = "FormInteropExcelPrint";
            this.Load += new System.EventHandler(this.FormInteropExcelPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDSOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDSOrders)).EndInit();
            this.toolStripFormInteropPrint.ResumeLayout(false);
            this.toolStripFormInteropPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource usersdbDSOrdersBindingSource;
        private usersdbDSOrders usersdbDSOrders;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private usersdbDSOrdersTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.ToolStrip toolStripFormInteropPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
    }
}