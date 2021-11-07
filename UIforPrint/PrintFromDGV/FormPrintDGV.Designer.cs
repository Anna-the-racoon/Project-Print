
namespace UIforPrint.PrintFromDGV
{
    partial class FormPreviewPrintPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreviewPrintPage));
            this.printPreviewControl = new System.Windows.Forms.PrintPreviewControl();
            this.printDocumentMaterials = new System.Drawing.Printing.PrintDocument();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxChoosePrinter = new System.Windows.Forms.ComboBox();
            this.numericUpDownCopies = new System.Windows.Forms.NumericUpDown();
            this.groupBoxCopies = new System.Windows.Forms.GroupBox();
            this.checkBoxCollateCopies = new System.Windows.Forms.CheckBox();
            this.groupBoxPrinterName = new System.Windows.Forms.GroupBox();
            this.groupBoxPageOrientation = new System.Windows.Forms.GroupBox();
            this.radioButtonLandscapeOrientation = new System.Windows.Forms.RadioButton();
            this.radioButtonPortraitOrientation = new System.Windows.Forms.RadioButton();
            this.groupBoxDuplexPrint = new System.Windows.Forms.GroupBox();
            this.checkBoxDuplexPrint = new System.Windows.Forms.CheckBox();
            this.comboBoxDuplexPrint = new System.Windows.Forms.ComboBox();
            this.groupBoxFieldSize = new System.Windows.Forms.GroupBox();
            this.comboBoxFieldSize = new System.Windows.Forms.ComboBox();
            this.buttonPrintOptions = new System.Windows.Forms.Button();
            this.printDialogMaretials = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopies)).BeginInit();
            this.groupBoxCopies.SuspendLayout();
            this.groupBoxPrinterName.SuspendLayout();
            this.groupBoxPageOrientation.SuspendLayout();
            this.groupBoxDuplexPrint.SuspendLayout();
            this.groupBoxFieldSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewControl
            // 
            this.printPreviewControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl.AutoZoom = false;
            this.printPreviewControl.BackColor = System.Drawing.SystemColors.Control;
            this.printPreviewControl.Document = this.printDocumentMaterials;
            this.printPreviewControl.Location = new System.Drawing.Point(0, 0);
            this.printPreviewControl.Margin = new System.Windows.Forms.Padding(50);
            this.printPreviewControl.Name = "printPreviewControl";
            this.printPreviewControl.Size = new System.Drawing.Size(454, 424);
            this.printPreviewControl.TabIndex = 0;
            this.printPreviewControl.Zoom = 0.36355859709153121D;
            // 
            // printDocumentMaterials
            // 
            this.printDocumentMaterials.DocumentName = "Order Materials";
            this.printDocumentMaterials.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.Location = new System.Drawing.Point(799, 5);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(105, 28);
            this.buttonPrint.TabIndex = 1;
            this.buttonPrint.Tag = "";
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(681, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 28);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxChoosePrinter
            // 
            this.comboBoxChoosePrinter.FormattingEnabled = true;
            this.comboBoxChoosePrinter.Location = new System.Drawing.Point(7, 21);
            this.comboBoxChoosePrinter.Name = "comboBoxChoosePrinter";
            this.comboBoxChoosePrinter.Size = new System.Drawing.Size(201, 21);
            this.comboBoxChoosePrinter.TabIndex = 3;
            // 
            // numericUpDownCopies
            // 
            this.numericUpDownCopies.Location = new System.Drawing.Point(6, 22);
            this.numericUpDownCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCopies.Name = "numericUpDownCopies";
            this.numericUpDownCopies.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownCopies.TabIndex = 6;
            this.numericUpDownCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCopies.ValueChanged += new System.EventHandler(this.numericUpDownCopies_ValueChanged);
            // 
            // groupBoxCopies
            // 
            this.groupBoxCopies.Controls.Add(this.checkBoxCollateCopies);
            this.groupBoxCopies.Controls.Add(this.numericUpDownCopies);
            this.groupBoxCopies.Location = new System.Drawing.Point(801, 108);
            this.groupBoxCopies.Name = "groupBoxCopies";
            this.groupBoxCopies.Size = new System.Drawing.Size(103, 70);
            this.groupBoxCopies.TabIndex = 7;
            this.groupBoxCopies.TabStop = false;
            this.groupBoxCopies.Text = "Copies";
            // 
            // checkBoxCollateCopies
            // 
            this.checkBoxCollateCopies.AutoSize = true;
            this.checkBoxCollateCopies.Enabled = false;
            this.checkBoxCollateCopies.Location = new System.Drawing.Point(6, 46);
            this.checkBoxCollateCopies.Name = "checkBoxCollateCopies";
            this.checkBoxCollateCopies.Size = new System.Drawing.Size(92, 17);
            this.checkBoxCollateCopies.TabIndex = 7;
            this.checkBoxCollateCopies.Text = "Collate copies";
            this.checkBoxCollateCopies.UseVisualStyleBackColor = true;
            // 
            // groupBoxPrinterName
            // 
            this.groupBoxPrinterName.Controls.Add(this.comboBoxChoosePrinter);
            this.groupBoxPrinterName.Location = new System.Drawing.Point(681, 39);
            this.groupBoxPrinterName.Name = "groupBoxPrinterName";
            this.groupBoxPrinterName.Size = new System.Drawing.Size(223, 63);
            this.groupBoxPrinterName.TabIndex = 8;
            this.groupBoxPrinterName.TabStop = false;
            this.groupBoxPrinterName.Text = "Printer Name";
            // 
            // groupBoxPageOrientation
            // 
            this.groupBoxPageOrientation.Controls.Add(this.radioButtonLandscapeOrientation);
            this.groupBoxPageOrientation.Controls.Add(this.radioButtonPortraitOrientation);
            this.groupBoxPageOrientation.Location = new System.Drawing.Point(681, 108);
            this.groupBoxPageOrientation.Name = "groupBoxPageOrientation";
            this.groupBoxPageOrientation.Size = new System.Drawing.Size(100, 70);
            this.groupBoxPageOrientation.TabIndex = 9;
            this.groupBoxPageOrientation.TabStop = false;
            this.groupBoxPageOrientation.Text = "Page orientation";
            // 
            // radioButtonLandscapeOrientation
            // 
            this.radioButtonLandscapeOrientation.AutoSize = true;
            this.radioButtonLandscapeOrientation.Location = new System.Drawing.Point(6, 42);
            this.radioButtonLandscapeOrientation.Name = "radioButtonLandscapeOrientation";
            this.radioButtonLandscapeOrientation.Size = new System.Drawing.Size(74, 17);
            this.radioButtonLandscapeOrientation.TabIndex = 1;
            this.radioButtonLandscapeOrientation.TabStop = true;
            this.radioButtonLandscapeOrientation.Text = "landscape";
            this.radioButtonLandscapeOrientation.UseVisualStyleBackColor = true;
            this.radioButtonLandscapeOrientation.CheckedChanged += new System.EventHandler(this.radioButtonLandscapeOrientation_CheckedChanged);
            // 
            // radioButtonPortraitOrientation
            // 
            this.radioButtonPortraitOrientation.AutoSize = true;
            this.radioButtonPortraitOrientation.Checked = true;
            this.radioButtonPortraitOrientation.Location = new System.Drawing.Point(6, 19);
            this.radioButtonPortraitOrientation.Name = "radioButtonPortraitOrientation";
            this.radioButtonPortraitOrientation.Size = new System.Drawing.Size(57, 17);
            this.radioButtonPortraitOrientation.TabIndex = 0;
            this.radioButtonPortraitOrientation.TabStop = true;
            this.radioButtonPortraitOrientation.Text = "portrait";
            this.radioButtonPortraitOrientation.UseVisualStyleBackColor = true;
            this.radioButtonPortraitOrientation.CheckedChanged += new System.EventHandler(this.radioButtonPortraitOrientation_CheckedChanged);
            // 
            // groupBoxDuplexPrint
            // 
            this.groupBoxDuplexPrint.Controls.Add(this.checkBoxDuplexPrint);
            this.groupBoxDuplexPrint.Controls.Add(this.comboBoxDuplexPrint);
            this.groupBoxDuplexPrint.Location = new System.Drawing.Point(460, 39);
            this.groupBoxDuplexPrint.Name = "groupBoxDuplexPrint";
            this.groupBoxDuplexPrint.Size = new System.Drawing.Size(207, 70);
            this.groupBoxDuplexPrint.TabIndex = 10;
            this.groupBoxDuplexPrint.TabStop = false;
            this.groupBoxDuplexPrint.Text = "Duplex print";
            // 
            // checkBoxDuplexPrint
            // 
            this.checkBoxDuplexPrint.AutoSize = true;
            this.checkBoxDuplexPrint.Location = new System.Drawing.Point(5, 19);
            this.checkBoxDuplexPrint.Name = "checkBoxDuplexPrint";
            this.checkBoxDuplexPrint.Size = new System.Drawing.Size(82, 17);
            this.checkBoxDuplexPrint.TabIndex = 8;
            this.checkBoxDuplexPrint.Text = "Duplex print";
            this.checkBoxDuplexPrint.UseVisualStyleBackColor = true;
            this.checkBoxDuplexPrint.CheckedChanged += new System.EventHandler(this.checkBoxDuplexPrint_CheckedChanged);
            // 
            // comboBoxDuplexPrint
            // 
            this.comboBoxDuplexPrint.Enabled = false;
            this.comboBoxDuplexPrint.FormattingEnabled = true;
            this.comboBoxDuplexPrint.Location = new System.Drawing.Point(5, 42);
            this.comboBoxDuplexPrint.Name = "comboBoxDuplexPrint";
            this.comboBoxDuplexPrint.Size = new System.Drawing.Size(181, 21);
            this.comboBoxDuplexPrint.TabIndex = 0;
            this.comboBoxDuplexPrint.SelectedIndexChanged += new System.EventHandler(this.comboBoxDuplexPrint_SelectedIndexChanged);
            // 
            // groupBoxFieldSize
            // 
            this.groupBoxFieldSize.Controls.Add(this.comboBoxFieldSize);
            this.groupBoxFieldSize.Location = new System.Drawing.Point(461, 115);
            this.groupBoxFieldSize.Name = "groupBoxFieldSize";
            this.groupBoxFieldSize.Size = new System.Drawing.Size(207, 59);
            this.groupBoxFieldSize.TabIndex = 10;
            this.groupBoxFieldSize.TabStop = false;
            this.groupBoxFieldSize.Text = "Field size";
            // 
            // comboBoxFieldSize
            // 
            this.comboBoxFieldSize.FormattingEnabled = true;
            this.comboBoxFieldSize.Location = new System.Drawing.Point(5, 19);
            this.comboBoxFieldSize.Name = "comboBoxFieldSize";
            this.comboBoxFieldSize.Size = new System.Drawing.Size(180, 21);
            this.comboBoxFieldSize.TabIndex = 9;
            // 
            // buttonPrintOptions
            // 
            this.buttonPrintOptions.Location = new System.Drawing.Point(807, 387);
            this.buttonPrintOptions.Name = "buttonPrintOptions";
            this.buttonPrintOptions.Size = new System.Drawing.Size(105, 25);
            this.buttonPrintOptions.TabIndex = 11;
            this.buttonPrintOptions.Text = "Print options";
            this.buttonPrintOptions.UseVisualStyleBackColor = true;
            this.buttonPrintOptions.Click += new System.EventHandler(this.buttonPrintOptions_Click);
            // 
            // printDialogMaretials
            // 
            this.printDialogMaretials.AllowCurrentPage = true;
            this.printDialogMaretials.AllowSelection = true;
            this.printDialogMaretials.AllowSomePages = true;
            this.printDialogMaretials.Document = this.printDocumentMaterials;
            this.printDialogMaretials.ShowHelp = true;
            this.printDialogMaretials.ShowNetwork = false;
            this.printDialogMaretials.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormPreviewPrintPage
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(920, 424);
            this.Controls.Add(this.buttonPrintOptions);
            this.Controls.Add(this.groupBoxFieldSize);
            this.Controls.Add(this.groupBoxDuplexPrint);
            this.Controls.Add(this.groupBoxPageOrientation);
            this.Controls.Add(this.groupBoxPrinterName);
            this.Controls.Add(this.groupBoxCopies);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.printPreviewControl);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormPreviewPrintPage";
            this.Text = "Preview print page ";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopies)).EndInit();
            this.groupBoxCopies.ResumeLayout(false);
            this.groupBoxCopies.PerformLayout();
            this.groupBoxPrinterName.ResumeLayout(false);
            this.groupBoxPageOrientation.ResumeLayout(false);
            this.groupBoxPageOrientation.PerformLayout();
            this.groupBoxDuplexPrint.ResumeLayout(false);
            this.groupBoxDuplexPrint.PerformLayout();
            this.groupBoxFieldSize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewControl printPreviewControl;
        private System.Drawing.Printing.PrintDocument printDocumentMaterials;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxChoosePrinter;
        private System.Windows.Forms.NumericUpDown numericUpDownCopies;
        private System.Windows.Forms.GroupBox groupBoxCopies;
        private System.Windows.Forms.GroupBox groupBoxPrinterName;
        private System.Windows.Forms.GroupBox groupBoxPageOrientation;
        private System.Windows.Forms.RadioButton radioButtonLandscapeOrientation;
        private System.Windows.Forms.RadioButton radioButtonPortraitOrientation;
        private System.Windows.Forms.GroupBox groupBoxDuplexPrint;
        private System.Windows.Forms.CheckBox checkBoxCollateCopies;
        private System.Windows.Forms.ComboBox comboBoxDuplexPrint;
        private System.Windows.Forms.CheckBox checkBoxDuplexPrint;
        private System.Windows.Forms.GroupBox groupBoxFieldSize;
        private System.Windows.Forms.ComboBox comboBoxFieldSize;
        private System.Windows.Forms.Button buttonPrintOptions;
        private System.Windows.Forms.PrintDialog printDialogMaretials;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}