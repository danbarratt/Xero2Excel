namespace Xero2Excel.UI.Excel2007AddIn {
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.interfaceRangeListview = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.interfaceNameCombobox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fieldRangesUnbindButton = new System.Windows.Forms.Button();
            this.fieldRangesBindButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.setupConsumerSecretTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.setupConsumerKeyTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.setupCurrentOrganisationTextbox = new System.Windows.Forms.TextBox();
            this.setupConnectionStatusLabel = new System.Windows.Forms.Label();
            this.setupConnectButton = new System.Windows.Forms.Button();
            this.bindableFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindableFieldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Download from Xero";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Upload to Xero";
            this.button3.UseVisualStyleBackColor = true;
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
            this.interfaceRangeListview.Location = new System.Drawing.Point(6, 6);
            this.interfaceRangeListview.Name = "interfaceRangeListview";
            this.interfaceRangeListview.Size = new System.Drawing.Size(311, 267);
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
            this.interfaceNameCombobox.Size = new System.Drawing.Size(334, 21);
            this.interfaceNameCombobox.TabIndex = 5;
            this.interfaceNameCombobox.SelectedIndexChanged += new System.EventHandler(this.interfaceNameCombobox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(334, 337);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fieldRangesUnbindButton);
            this.tabPage1.Controls.Add(this.fieldRangesBindButton);
            this.tabPage1.Controls.Add(this.interfaceRangeListview);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(326, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Field Ranges";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fieldRangesUnbindButton
            // 
            this.fieldRangesUnbindButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fieldRangesUnbindButton.Location = new System.Drawing.Point(220, 279);
            this.fieldRangesUnbindButton.Name = "fieldRangesUnbindButton";
            this.fieldRangesUnbindButton.Size = new System.Drawing.Size(97, 23);
            this.fieldRangesUnbindButton.TabIndex = 9;
            this.fieldRangesUnbindButton.Text = "Unbind";
            this.fieldRangesUnbindButton.UseVisualStyleBackColor = true;
            this.fieldRangesUnbindButton.Click += new System.EventHandler(this.fieldRangesUnbindButton_Click);
            // 
            // fieldRangesBindButton
            // 
            this.fieldRangesBindButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fieldRangesBindButton.Location = new System.Drawing.Point(117, 279);
            this.fieldRangesBindButton.Name = "fieldRangesBindButton";
            this.fieldRangesBindButton.Size = new System.Drawing.Size(97, 23);
            this.fieldRangesBindButton.TabIndex = 8;
            this.fieldRangesBindButton.Text = "Bind";
            this.fieldRangesBindButton.UseVisualStyleBackColor = true;
            this.fieldRangesBindButton.Click += new System.EventHandler(this.fieldRangesBindButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.setupConsumerSecretTextbox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.setupConsumerKeyTextbox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.setupCurrentOrganisationTextbox);
            this.tabPage2.Controls.Add(this.setupConnectionStatusLabel);
            this.tabPage2.Controls.Add(this.setupConnectButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(326, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Consumer Secret";
            // 
            // setupConsumerSecretTextbox
            // 
            this.setupConsumerSecretTextbox.Location = new System.Drawing.Point(113, 32);
            this.setupConsumerSecretTextbox.Name = "setupConsumerSecretTextbox";
            this.setupConsumerSecretTextbox.PasswordChar = '*';
            this.setupConsumerSecretTextbox.Size = new System.Drawing.Size(205, 20);
            this.setupConsumerSecretTextbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Consumer Key";
            // 
            // setupConsumerKeyTextbox
            // 
            this.setupConsumerKeyTextbox.Location = new System.Drawing.Point(114, 6);
            this.setupConsumerKeyTextbox.Name = "setupConsumerKeyTextbox";
            this.setupConsumerKeyTextbox.Size = new System.Drawing.Size(205, 20);
            this.setupConsumerKeyTextbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current Organisation";
            // 
            // setupCurrentOrganisationTextbox
            // 
            this.setupCurrentOrganisationTextbox.Location = new System.Drawing.Point(114, 87);
            this.setupCurrentOrganisationTextbox.Name = "setupCurrentOrganisationTextbox";
            this.setupCurrentOrganisationTextbox.Size = new System.Drawing.Size(205, 20);
            this.setupCurrentOrganisationTextbox.TabIndex = 2;
            // 
            // setupConnectionStatusLabel
            // 
            this.setupConnectionStatusLabel.AutoSize = true;
            this.setupConnectionStatusLabel.Location = new System.Drawing.Point(5, 63);
            this.setupConnectionStatusLabel.Name = "setupConnectionStatusLabel";
            this.setupConnectionStatusLabel.Size = new System.Drawing.Size(43, 13);
            this.setupConnectionStatusLabel.TabIndex = 1;
            this.setupConnectionStatusLabel.Text = "{status}";
            // 
            // setupConnectButton
            // 
            this.setupConnectButton.Location = new System.Drawing.Point(244, 58);
            this.setupConnectButton.Name = "setupConnectButton";
            this.setupConnectButton.Size = new System.Drawing.Size(75, 23);
            this.setupConnectButton.TabIndex = 0;
            this.setupConnectButton.Text = "Connect";
            this.setupConnectButton.UseVisualStyleBackColor = true;
            this.setupConnectButton.Click += new System.EventHandler(this.setupConnectButton_Click);
            // 
            // bindableFieldBindingSource
            // 
            this.bindableFieldBindingSource.DataSource = typeof(Xero2Excel.Contracts.Binding.BindableField);
            // 
            // Xero2ExcelWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 429);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.interfaceNameCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Xero2ExcelWinForm";
            this.Text = "Xero2Excel";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Xero2ExcelWinForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindableFieldBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView interfaceRangeListview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox interfaceNameCombobox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource bindableFieldBindingSource;
        private System.Windows.Forms.Button fieldRangesBindButton;
        private System.Windows.Forms.Button fieldRangesUnbindButton;
        private System.Windows.Forms.Label setupConnectionStatusLabel;
        private System.Windows.Forms.Button setupConnectButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox setupConsumerSecretTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox setupConsumerKeyTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox setupCurrentOrganisationTextbox;
    }
}