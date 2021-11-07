namespace UIforPrint
{
    partial class Form1
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
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.tabControlPreviewDialog = new System.Windows.Forms.TabControl();
            this.tabPagePrinter = new System.Windows.Forms.TabPage();
            this.tabPagePaper = new System.Windows.Forms.TabPage();
            this.tabControlPreviewDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.printPreviewControl1.Location = new System.Drawing.Point(1, 8);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(382, 430);
            this.printPreviewControl1.TabIndex = 0;
            // 
            // tabControlPreviewDialog
            // 
            this.tabControlPreviewDialog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPreviewDialog.Controls.Add(this.tabPagePrinter);
            this.tabControlPreviewDialog.Controls.Add(this.tabPagePaper);
            this.tabControlPreviewDialog.Location = new System.Drawing.Point(406, 0);
            this.tabControlPreviewDialog.Name = "tabControlPreviewDialog";
            this.tabControlPreviewDialog.SelectedIndex = 0;
            this.tabControlPreviewDialog.Size = new System.Drawing.Size(394, 450);
            this.tabControlPreviewDialog.TabIndex = 1;
            // 
            // tabPagePrinter
            // 
            this.tabPagePrinter.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrinter.Name = "tabPagePrinter";
            this.tabPagePrinter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrinter.Size = new System.Drawing.Size(386, 424);
            this.tabPagePrinter.TabIndex = 0;
            this.tabPagePrinter.Text = "Printer";
            this.tabPagePrinter.UseVisualStyleBackColor = true;
            // 
            // tabPagePaper
            // 
            this.tabPagePaper.Location = new System.Drawing.Point(4, 22);
            this.tabPagePaper.Name = "tabPagePaper";
            this.tabPagePaper.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePaper.Size = new System.Drawing.Size(386, 424);
            this.tabPagePaper.TabIndex = 1;
            this.tabPagePaper.Text = "Paper";
            this.tabPagePaper.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlPreviewDialog);
            this.Controls.Add(this.printPreviewControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlPreviewDialog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.TabControl tabControlPreviewDialog;
        private System.Windows.Forms.TabPage tabPagePrinter;
        private System.Windows.Forms.TabPage tabPagePaper;
    }
}