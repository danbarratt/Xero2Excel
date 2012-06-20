namespace Xero2Excel.Core.UI {
    partial class Xero2ExcelWinForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.downloadButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.interfaceRangeListview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.interfaceNameCombobox = new System.Windows.Forms.ComboBox();
            this.fieldRangesUnbindButton = new System.Windows.Forms.Button();
            this.fieldRangesBindButton = new System.Windows.Forms.Button();
            this.bindableFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindableFieldBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(118, 395);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(112, 23);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "&Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(236, 395);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(112, 23);
            this.uploadButton.TabIndex = 2;
            this.uploadButton.Text = "&Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            // 
            // interfaceRangeListview
            // 
            this.interfaceRangeListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.interfaceRangeListview.FullRowSelect = true;
            this.interfaceRangeListview.GridLines = true;
            this.interfaceRangeListview.Location = new System.Drawing.Point(6, 19);
            this.interfaceRangeListview.Name = "interfaceRangeListview";
            this.interfaceRangeListview.Size = new System.Drawing.Size(324, 283);
            this.interfaceRangeListview.TabIndex = 3;
            this.interfaceRangeListview.UseCompatibleStateImageBehavior = false;
            this.interfaceRangeListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Data Field";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Required";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Multi Field";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Range";
            this.columnHeader4.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select type of data to import:";
            // 
            // interfaceNameCombobox
            // 
            this.interfaceNameCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interfaceNameCombobox.FormattingEnabled = true;
            this.interfaceNameCombobox.Location = new System.Drawing.Point(12, 25);
            this.interfaceNameCombobox.Name = "interfaceNameCombobox";
            this.interfaceNameCombobox.Size = new System.Drawing.Size(230, 21);
            this.interfaceNameCombobox.TabIndex = 5;
            this.interfaceNameCombobox.SelectedIndexChanged += new System.EventHandler(this.interfaceNameCombobox_SelectedIndexChanged);
            // 
            // fieldRangesUnbindButton
            // 
            this.fieldRangesUnbindButton.Location = new System.Drawing.Point(254, 308);
            this.fieldRangesUnbindButton.Name = "fieldRangesUnbindButton";
            this.fieldRangesUnbindButton.Size = new System.Drawing.Size(76, 23);
            this.fieldRangesUnbindButton.TabIndex = 9;
            this.fieldRangesUnbindButton.Text = "U&nbind";
            this.fieldRangesUnbindButton.UseVisualStyleBackColor = true;
            this.fieldRangesUnbindButton.Click += new System.EventHandler(this.fieldRangesUnbindButton_Click);
            // 
            // fieldRangesBindButton
            // 
            this.fieldRangesBindButton.Location = new System.Drawing.Point(172, 308);
            this.fieldRangesBindButton.Name = "fieldRangesBindButton";
            this.fieldRangesBindButton.Size = new System.Drawing.Size(76, 23);
            this.fieldRangesBindButton.TabIndex = 8;
            this.fieldRangesBindButton.Text = "&Bind";
            this.fieldRangesBindButton.UseVisualStyleBackColor = true;
            this.fieldRangesBindButton.Click += new System.EventHandler(this.fieldRangesBindButton_Click);
            // 
            // bindableFieldBindingSource
            // 
            this.bindableFieldBindingSource.DataSource = typeof(Xero2Excel.Contracts.Binding.BindableField);
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(272, 12);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(76, 23);
            this.setupButton.TabIndex = 9;
            this.setupButton.Text = "&Setup..";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fieldRangesUnbindButton);
            this.groupBox1.Controls.Add(this.interfaceRangeListview);
            this.groupBox1.Controls.Add(this.fieldRangesBindButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 337);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Named Ranges";
            // 
            // Xero2ExcelWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.setupButton);
            this.Controls.Add(this.interfaceNameCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.downloadButton);
            this.Name = "Xero2ExcelWinForm";
            this.Text = "Xero2Excel";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Xero2ExcelWinForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindableFieldBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.ListView interfaceRangeListview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox interfaceNameCombobox;
        private System.Windows.Forms.BindingSource bindableFieldBindingSource;
        private System.Windows.Forms.Button fieldRangesBindButton;
        private System.Windows.Forms.Button fieldRangesUnbindButton;
        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}