
namespace UIforPrint.my
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
            this.printDialogPlanDetail = new System.Windows.Forms.PrintDialog();
            this.printDocumentPlanDetail = new System.Drawing.Printing.PrintDocument();
            this.radioButtonCustomizable = new System.Windows.Forms.RadioButton();
            this.radioButtonWide = new System.Windows.Forms.RadioButton();
            this.radioButtonRegular = new System.Windows.Forms.RadioButton();
            this.radioButtonNarrow = new System.Windows.Forms.RadioButton();
            this.groupBoxPageSize = new System.Windows.Forms.GroupBox();
            this.comboBoxPageSize = new System.Windows.Forms.ComboBox();
            this.groupBoxPageFields = new System.Windows.Forms.GroupBox();
            this.groupBoxPrinterName = new System.Windows.Forms.GroupBox();
            this.comboBoxChoosePrinter = new System.Windows.Forms.ComboBox();
            this.checkBoxDuplexPrint = new System.Windows.Forms.CheckBox();
            this.groupBoxPageOrientation = new System.Windows.Forms.GroupBox();
            this.radioButtonLandscapeOrientation = new System.Windows.Forms.RadioButton();
            this.radioButtonPortraitOrientation = new System.Windows.Forms.RadioButton();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printPreviewControlPrintDetail = new System.Windows.Forms.PrintPreviewControl();
            this.groupBoxDuplexPrint = new System.Windows.Forms.GroupBox();
            this.pageSetupDialogPlanDetail = new System.Windows.Forms.PageSetupDialog();
            this.checkBoxCollateCopies = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxZoom = new System.Windows.Forms.GroupBox();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxCustomizeField = new System.Windows.Forms.GroupBox();
            this.labelLeftSm = new System.Windows.Forms.Label();
            this.labelBottomSm = new System.Windows.Forms.Label();
            this.labelRightSm = new System.Windows.Forms.Label();
            this.labelTopSm = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.textBoxBottom = new System.Windows.Forms.TextBox();
            this.textBoxTop = new System.Windows.Forms.TextBox();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.labelBottom = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.groupBoxCopies = new System.Windows.Forms.GroupBox();
            this.numericUpDownCopies = new System.Windows.Forms.NumericUpDown();
            this.groupBoxPageSize.SuspendLayout();
            this.groupBoxPageFields.SuspendLayout();
            this.groupBoxPrinterName.SuspendLayout();
            this.groupBoxPageOrientation.SuspendLayout();
            this.groupBoxDuplexPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.groupBoxCustomizeField.SuspendLayout();
            this.groupBoxCopies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialogPlanDetail
            // 
            this.printDialogPlanDetail.Document = this.printDocumentPlanDetail;
            this.printDialogPlanDetail.UseEXDialog = true;
            // 
            // printDocumentPlanDetail
            // 
            this.printDocumentPlanDetail.DocumentName = "Print plan detail";
            // 
            // radioButtonCustomizable
            // 
            this.radioButtonCustomizable.AutoSize = true;
            this.radioButtonCustomizable.Location = new System.Drawing.Point(111, 42);
            this.radioButtonCustomizable.Name = "radioButtonCustomizable";
            this.radioButtonCustomizable.Size = new System.Drawing.Size(86, 17);
            this.radioButtonCustomizable.TabIndex = 3;
            this.radioButtonCustomizable.Text = "customizable";
            this.radioButtonCustomizable.UseVisualStyleBackColor = true;
            // 
            // radioButtonWide
            // 
            this.radioButtonWide.AutoSize = true;
            this.radioButtonWide.Location = new System.Drawing.Point(111, 19);
            this.radioButtonWide.Name = "radioButtonWide";
            this.radioButtonWide.Size = new System.Drawing.Size(47, 17);
            this.radioButtonWide.TabIndex = 2;
            this.radioButtonWide.Text = "wide";
            this.radioButtonWide.UseVisualStyleBackColor = true;
            // 
            // radioButtonRegular
            // 
            this.radioButtonRegular.AutoSize = true;
            this.radioButtonRegular.Checked = true;
            this.radioButtonRegular.Location = new System.Drawing.Point(6, 42);
            this.radioButtonRegular.Name = "radioButtonRegular";
            this.radioButtonRegular.Size = new System.Drawing.Size(57, 17);
            this.radioButtonRegular.TabIndex = 1;
            this.radioButtonRegular.TabStop = true;
            this.radioButtonRegular.Text = "regular";
            this.radioButtonRegular.UseVisualStyleBackColor = true;
            // 
            // radioButtonNarrow
            // 
            this.radioButtonNarrow.AutoSize = true;
            this.radioButtonNarrow.Location = new System.Drawing.Point(6, 19);
            this.radioButtonNarrow.Name = "radioButtonNarrow";
            this.radioButtonNarrow.Size = new System.Drawing.Size(57, 17);
            this.radioButtonNarrow.TabIndex = 0;
            this.radioButtonNarrow.Text = "narrow";
            this.radioButtonNarrow.UseVisualStyleBackColor = true;
            // 
            // groupBoxPageSize
            // 
            this.groupBoxPageSize.Controls.Add(this.comboBoxPageSize);
            this.groupBoxPageSize.Location = new System.Drawing.Point(7, 252);
            this.groupBoxPageSize.Name = "groupBoxPageSize";
            this.groupBoxPageSize.Size = new System.Drawing.Size(239, 51);
            this.groupBoxPageSize.TabIndex = 25;
            this.groupBoxPageSize.TabStop = false;
            this.groupBoxPageSize.Text = "Page size";
            // 
            // comboBoxPageSize
            // 
            this.comboBoxPageSize.FormattingEnabled = true;
            this.comboBoxPageSize.Location = new System.Drawing.Point(6, 19);
            this.comboBoxPageSize.Name = "comboBoxPageSize";
            this.comboBoxPageSize.Size = new System.Drawing.Size(222, 21);
            this.comboBoxPageSize.TabIndex = 3;
            // 
            // groupBoxPageFields
            // 
            this.groupBoxPageFields.Controls.Add(this.radioButtonCustomizable);
            this.groupBoxPageFields.Controls.Add(this.radioButtonWide);
            this.groupBoxPageFields.Controls.Add(this.radioButtonRegular);
            this.groupBoxPageFields.Controls.Add(this.radioButtonNarrow);
            this.groupBoxPageFields.Location = new System.Drawing.Point(7, 383);
            this.groupBoxPageFields.Name = "groupBoxPageFields";
            this.groupBoxPageFields.Size = new System.Drawing.Size(239, 65);
            this.groupBoxPageFields.TabIndex = 26;
            this.groupBoxPageFields.TabStop = false;
            this.groupBoxPageFields.Text = "Page fields";
            // 
            // groupBoxPrinterName
            // 
            this.groupBoxPrinterName.Controls.Add(this.comboBoxChoosePrinter);
            this.groupBoxPrinterName.Location = new System.Drawing.Point(7, 46);
            this.groupBoxPrinterName.Name = "groupBoxPrinterName";
            this.groupBoxPrinterName.Size = new System.Drawing.Size(239, 53);
            this.groupBoxPrinterName.TabIndex = 22;
            this.groupBoxPrinterName.TabStop = false;
            this.groupBoxPrinterName.Text = "Printer Name";
            // 
            // comboBoxChoosePrinter
            // 
            this.comboBoxChoosePrinter.FormattingEnabled = true;
            this.comboBoxChoosePrinter.Location = new System.Drawing.Point(6, 22);
            this.comboBoxChoosePrinter.Name = "comboBoxChoosePrinter";
            this.comboBoxChoosePrinter.Size = new System.Drawing.Size(222, 21);
            this.comboBoxChoosePrinter.TabIndex = 3;
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
            // 
            // groupBoxPageOrientation
            // 
            this.groupBoxPageOrientation.Controls.Add(this.radioButtonLandscapeOrientation);
            this.groupBoxPageOrientation.Controls.Add(this.radioButtonPortraitOrientation);
            this.groupBoxPageOrientation.Location = new System.Drawing.Point(7, 105);
            this.groupBoxPageOrientation.Name = "groupBoxPageOrientation";
            this.groupBoxPageOrientation.Size = new System.Drawing.Size(239, 40);
            this.groupBoxPageOrientation.TabIndex = 23;
            this.groupBoxPageOrientation.TabStop = false;
            this.groupBoxPageOrientation.Text = "Page orientation";
            // 
            // radioButtonLandscapeOrientation
            // 
            this.radioButtonLandscapeOrientation.AutoSize = true;
            this.radioButtonLandscapeOrientation.Location = new System.Drawing.Point(119, 19);
            this.radioButtonLandscapeOrientation.Name = "radioButtonLandscapeOrientation";
            this.radioButtonLandscapeOrientation.Size = new System.Drawing.Size(74, 17);
            this.radioButtonLandscapeOrientation.TabIndex = 1;
            this.radioButtonLandscapeOrientation.Text = "landscape";
            this.radioButtonLandscapeOrientation.UseVisualStyleBackColor = true;
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
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPrint.Location = new System.Drawing.Point(129, 12);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(105, 28);
            this.buttonPrint.TabIndex = 11;
            this.buttonPrint.Tag = "";
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // printPreviewControlPrintDetail
            // 
            this.printPreviewControlPrintDetail.AutoZoom = false;
            this.printPreviewControlPrintDetail.BackColor = System.Drawing.SystemColors.Control;
            this.printPreviewControlPrintDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.printPreviewControlPrintDetail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.printPreviewControlPrintDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreviewControlPrintDetail.Document = this.printDocumentPlanDetail;
            this.printPreviewControlPrintDetail.Location = new System.Drawing.Point(0, 0);
            this.printPreviewControlPrintDetail.Name = "printPreviewControlPrintDetail";
            this.printPreviewControlPrintDetail.Size = new System.Drawing.Size(758, 542);
            this.printPreviewControlPrintDetail.TabIndex = 0;
            this.printPreviewControlPrintDetail.Zoom = 0.43284858853721131D;
            // 
            // groupBoxDuplexPrint
            // 
            this.groupBoxDuplexPrint.Controls.Add(this.checkBoxDuplexPrint);
            this.groupBoxDuplexPrint.Location = new System.Drawing.Point(7, 204);
            this.groupBoxDuplexPrint.Name = "groupBoxDuplexPrint";
            this.groupBoxDuplexPrint.Size = new System.Drawing.Size(239, 42);
            this.groupBoxDuplexPrint.TabIndex = 24;
            this.groupBoxDuplexPrint.TabStop = false;
            this.groupBoxDuplexPrint.Text = "Duplex print";
            // 
            // pageSetupDialogPlanDetail
            // 
            this.pageSetupDialogPlanDetail.Document = this.printDocumentPlanDetail;
            // 
            // checkBoxCollateCopies
            // 
            this.checkBoxCollateCopies.AutoSize = true;
            this.checkBoxCollateCopies.Enabled = false;
            this.checkBoxCollateCopies.Location = new System.Drawing.Point(87, 19);
            this.checkBoxCollateCopies.Name = "checkBoxCollateCopies";
            this.checkBoxCollateCopies.Size = new System.Drawing.Size(92, 17);
            this.checkBoxCollateCopies.TabIndex = 7;
            this.checkBoxCollateCopies.Text = "Collate copies";
            this.checkBoxCollateCopies.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxZoom);
            this.splitContainer1.Panel1.Controls.Add(this.buttonClose);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxCustomizeField);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxCopies);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxPageFields);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxPageSize);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxPrinterName);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxDuplexPrint);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxPageOrientation);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPrint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.printPreviewControlPrintDetail);
            this.splitContainer1.Size = new System.Drawing.Size(1023, 542);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 20;
            // 
            // groupBoxZoom
            // 
            this.groupBoxZoom.Controls.Add(this.trackBarZoom);
            this.groupBoxZoom.Location = new System.Drawing.Point(7, 309);
            this.groupBoxZoom.Name = "groupBoxZoom";
            this.groupBoxZoom.Size = new System.Drawing.Size(239, 68);
            this.groupBoxZoom.TabIndex = 30;
            this.groupBoxZoom.TabStop = false;
            this.groupBoxZoom.Text = "Zoom";
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.LargeChange = 90;
            this.trackBarZoom.Location = new System.Drawing.Point(6, 17);
            this.trackBarZoom.Maximum = 100;
            this.trackBarZoom.Minimum = 10;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(222, 45);
            this.trackBarZoom.SmallChange = 5;
            this.trackBarZoom.TabIndex = 29;
            this.trackBarZoom.Tag = "";
            this.trackBarZoom.TickFrequency = 5;
            this.trackBarZoom.Value = 75;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClose.Location = new System.Drawing.Point(15, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 28);
            this.buttonClose.TabIndex = 28;
            this.buttonClose.Tag = "";
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // groupBoxCustomizeField
            // 
            this.groupBoxCustomizeField.Controls.Add(this.labelLeftSm);
            this.groupBoxCustomizeField.Controls.Add(this.labelBottomSm);
            this.groupBoxCustomizeField.Controls.Add(this.labelRightSm);
            this.groupBoxCustomizeField.Controls.Add(this.labelTopSm);
            this.groupBoxCustomizeField.Controls.Add(this.buttonApply);
            this.groupBoxCustomizeField.Controls.Add(this.textBoxRight);
            this.groupBoxCustomizeField.Controls.Add(this.textBoxLeft);
            this.groupBoxCustomizeField.Controls.Add(this.textBoxBottom);
            this.groupBoxCustomizeField.Controls.Add(this.textBoxTop);
            this.groupBoxCustomizeField.Controls.Add(this.labelTop);
            this.groupBoxCustomizeField.Controls.Add(this.labelLeft);
            this.groupBoxCustomizeField.Controls.Add(this.labelBottom);
            this.groupBoxCustomizeField.Controls.Add(this.labelRight);
            this.groupBoxCustomizeField.Enabled = false;
            this.groupBoxCustomizeField.Location = new System.Drawing.Point(7, 454);
            this.groupBoxCustomizeField.Name = "groupBoxCustomizeField";
            this.groupBoxCustomizeField.Size = new System.Drawing.Size(239, 143);
            this.groupBoxCustomizeField.TabIndex = 27;
            this.groupBoxCustomizeField.TabStop = false;
            this.groupBoxCustomizeField.Text = "Customize fields";
            // 
            // labelLeftSm
            // 
            this.labelLeftSm.AutoSize = true;
            this.labelLeftSm.Location = new System.Drawing.Point(61, 85);
            this.labelLeftSm.Name = "labelLeftSm";
            this.labelLeftSm.Size = new System.Drawing.Size(24, 13);
            this.labelLeftSm.TabIndex = 12;
            this.labelLeftSm.Text = "см.";
            // 
            // labelBottomSm
            // 
            this.labelBottomSm.AutoSize = true;
            this.labelBottomSm.Location = new System.Drawing.Point(179, 85);
            this.labelBottomSm.Name = "labelBottomSm";
            this.labelBottomSm.Size = new System.Drawing.Size(24, 13);
            this.labelBottomSm.TabIndex = 11;
            this.labelBottomSm.Text = "см.";
            // 
            // labelRightSm
            // 
            this.labelRightSm.AutoSize = true;
            this.labelRightSm.Location = new System.Drawing.Point(179, 39);
            this.labelRightSm.Name = "labelRightSm";
            this.labelRightSm.Size = new System.Drawing.Size(24, 13);
            this.labelRightSm.TabIndex = 10;
            this.labelRightSm.Text = "см.";
            // 
            // labelTopSm
            // 
            this.labelTopSm.AutoSize = true;
            this.labelTopSm.Location = new System.Drawing.Point(61, 39);
            this.labelTopSm.Name = "labelTopSm";
            this.labelTopSm.Size = new System.Drawing.Size(24, 13);
            this.labelTopSm.TabIndex = 9;
            this.labelTopSm.Text = "см.";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(126, 116);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(77, 21);
            this.buttonApply.TabIndex = 8;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // textBoxRight
            // 
            this.textBoxRight.Location = new System.Drawing.Point(126, 36);
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.Size = new System.Drawing.Size(47, 20);
            this.textBoxRight.TabIndex = 7;
            this.textBoxRight.Text = "2";
            // 
            // textBoxLeft
            // 
            this.textBoxLeft.Location = new System.Drawing.Point(11, 82);
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.Size = new System.Drawing.Size(46, 20);
            this.textBoxLeft.TabIndex = 6;
            this.textBoxLeft.Text = "3";
            // 
            // textBoxBottom
            // 
            this.textBoxBottom.Location = new System.Drawing.Point(126, 82);
            this.textBoxBottom.Name = "textBoxBottom";
            this.textBoxBottom.Size = new System.Drawing.Size(47, 20);
            this.textBoxBottom.TabIndex = 5;
            this.textBoxBottom.Text = "2";
            // 
            // textBoxTop
            // 
            this.textBoxTop.Location = new System.Drawing.Point(12, 36);
            this.textBoxTop.Name = "textBoxTop";
            this.textBoxTop.Size = new System.Drawing.Size(45, 20);
            this.textBoxTop.TabIndex = 4;
            this.textBoxTop.Text = "2";
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Location = new System.Drawing.Point(15, 20);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(26, 13);
            this.labelTop.TabIndex = 3;
            this.labelTop.Text = "Top";
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.Location = new System.Drawing.Point(15, 66);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(25, 13);
            this.labelLeft.TabIndex = 0;
            this.labelLeft.Text = "Left";
            // 
            // labelBottom
            // 
            this.labelBottom.AutoSize = true;
            this.labelBottom.Location = new System.Drawing.Point(128, 66);
            this.labelBottom.Name = "labelBottom";
            this.labelBottom.Size = new System.Drawing.Size(40, 13);
            this.labelBottom.TabIndex = 2;
            this.labelBottom.Text = "Bottom";
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Location = new System.Drawing.Point(128, 20);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(32, 13);
            this.labelRight.TabIndex = 1;
            this.labelRight.Text = "Right";
            // 
            // groupBoxCopies
            // 
            this.groupBoxCopies.Controls.Add(this.checkBoxCollateCopies);
            this.groupBoxCopies.Controls.Add(this.numericUpDownCopies);
            this.groupBoxCopies.Location = new System.Drawing.Point(7, 151);
            this.groupBoxCopies.Name = "groupBoxCopies";
            this.groupBoxCopies.Size = new System.Drawing.Size(239, 47);
            this.groupBoxCopies.TabIndex = 21;
            this.groupBoxCopies.TabStop = false;
            this.groupBoxCopies.Text = "Number of copies";
            // 
            // numericUpDownCopies
            // 
            this.numericUpDownCopies.Location = new System.Drawing.Point(6, 19);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 542);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxPageSize.ResumeLayout(false);
            this.groupBoxPageFields.ResumeLayout(false);
            this.groupBoxPageFields.PerformLayout();
            this.groupBoxPrinterName.ResumeLayout(false);
            this.groupBoxPageOrientation.ResumeLayout(false);
            this.groupBoxPageOrientation.PerformLayout();
            this.groupBoxDuplexPrint.ResumeLayout(false);
            this.groupBoxDuplexPrint.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxZoom.ResumeLayout(false);
            this.groupBoxZoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.groupBoxCustomizeField.ResumeLayout(false);
            this.groupBoxCustomizeField.PerformLayout();
            this.groupBoxCopies.ResumeLayout(false);
            this.groupBoxCopies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialogPlanDetail;
        private System.Drawing.Printing.PrintDocument printDocumentPlanDetail;
        private System.Windows.Forms.RadioButton radioButtonCustomizable;
        private System.Windows.Forms.RadioButton radioButtonWide;
        private System.Windows.Forms.RadioButton radioButtonRegular;
        private System.Windows.Forms.RadioButton radioButtonNarrow;
        private System.Windows.Forms.GroupBox groupBoxPageSize;
        private System.Windows.Forms.ComboBox comboBoxPageSize;
        private System.Windows.Forms.GroupBox groupBoxPageFields;
        private System.Windows.Forms.GroupBox groupBoxPrinterName;
        private System.Windows.Forms.ComboBox comboBoxChoosePrinter;
        private System.Windows.Forms.CheckBox checkBoxDuplexPrint;
        private System.Windows.Forms.GroupBox groupBoxPageOrientation;
        private System.Windows.Forms.RadioButton radioButtonLandscapeOrientation;
        private System.Windows.Forms.RadioButton radioButtonPortraitOrientation;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PrintPreviewControl printPreviewControlPrintDetail;
        private System.Windows.Forms.GroupBox groupBoxDuplexPrint;
        private System.Windows.Forms.PageSetupDialog pageSetupDialogPlanDetail;
        private System.Windows.Forms.CheckBox checkBoxCollateCopies;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxZoom;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxCustomizeField;
        private System.Windows.Forms.Label labelLeftSm;
        private System.Windows.Forms.Label labelBottomSm;
        private System.Windows.Forms.Label labelRightSm;
        private System.Windows.Forms.Label labelTopSm;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.TextBox textBoxLeft;
        private System.Windows.Forms.TextBox textBoxBottom;
        private System.Windows.Forms.TextBox textBoxTop;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelBottom;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.GroupBox groupBoxCopies;
        private System.Windows.Forms.NumericUpDown numericUpDownCopies;
    }
}