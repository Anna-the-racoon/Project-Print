namespace UIforPrint
{
    partial class FormButtonsPrint
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
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPrintFromDGV = new System.Windows.Forms.Button();
            this.buttonExcelInteropPrint = new System.Windows.Forms.Button();
            this.buttonOoInteropPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.buttonPrintDoublePreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(12, 12);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(214, 174);
            this.buttonPrint.TabIndex = 0;
            this.buttonPrint.Text = "Print the String";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(452, 192);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(214, 174);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonPrintFromDGV
            // 
            this.buttonPrintFromDGV.Location = new System.Drawing.Point(232, 12);
            this.buttonPrintFromDGV.Name = "buttonPrintFromDGV";
            this.buttonPrintFromDGV.Size = new System.Drawing.Size(214, 174);
            this.buttonPrintFromDGV.TabIndex = 3;
            this.buttonPrintFromDGV.Text = "Print from DGV";
            this.buttonPrintFromDGV.UseVisualStyleBackColor = true;
            this.buttonPrintFromDGV.Click += new System.EventHandler(this.buttonPrintOrders_Click);
            // 
            // buttonExcelInteropPrint
            // 
            this.buttonExcelInteropPrint.Location = new System.Drawing.Point(452, 12);
            this.buttonExcelInteropPrint.Name = "buttonExcelInteropPrint";
            this.buttonExcelInteropPrint.Size = new System.Drawing.Size(214, 174);
            this.buttonExcelInteropPrint.TabIndex = 4;
            this.buttonExcelInteropPrint.Text = "Excel interop print";
            this.buttonExcelInteropPrint.UseVisualStyleBackColor = true;
            this.buttonExcelInteropPrint.Click += new System.EventHandler(this.buttonExcelInteropPrint_Click);
            // 
            // buttonOoInteropPrint
            // 
            this.buttonOoInteropPrint.Location = new System.Drawing.Point(12, 192);
            this.buttonOoInteropPrint.Name = "buttonOoInteropPrint";
            this.buttonOoInteropPrint.Size = new System.Drawing.Size(214, 174);
            this.buttonOoInteropPrint.TabIndex = 5;
            this.buttonOoInteropPrint.Text = "Open Office interop print";
            this.buttonOoInteropPrint.UseVisualStyleBackColor = true;
            this.buttonOoInteropPrint.Click += new System.EventHandler(this.buttonOoInteropPrint_Click);
            // 
            // buttonPrintDoublePreview
            // 
            this.buttonPrintDoublePreview.Location = new System.Drawing.Point(232, 192);
            this.buttonPrintDoublePreview.Name = "buttonPrintDoublePreview";
            this.buttonPrintDoublePreview.Size = new System.Drawing.Size(214, 174);
            this.buttonPrintDoublePreview.TabIndex = 6;
            this.buttonPrintDoublePreview.Text = "Print";
            this.buttonPrintDoublePreview.UseVisualStyleBackColor = true;
            this.buttonPrintDoublePreview.Click += new System.EventHandler(this.buttonPrintDoublePreview_Click);
            // 
            // FormButtonsPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 376);
            this.Controls.Add(this.buttonPrintDoublePreview);
            this.Controls.Add(this.buttonOoInteropPrint);
            this.Controls.Add(this.buttonExcelInteropPrint);
            this.Controls.Add(this.buttonPrintFromDGV);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPrint);
            this.Name = "FormButtonsPrint";
            this.Text = "Print";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPrintFromDGV;
        private System.Windows.Forms.Button buttonExcelInteropPrint;
        private System.Windows.Forms.Button buttonOoInteropPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button buttonPrintDoublePreview;
    }
}

