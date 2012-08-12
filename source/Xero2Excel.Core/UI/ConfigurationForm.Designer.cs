namespace Xero2Excel.Core.UI
{
    partial class ConfigurationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.NotConnectedPanel = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ConnectionDetailsPanel = new System.Windows.Forms.Panel();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.currentAuthorisationGrantedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.currentAuthorisationExpiresTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentAccessTokenTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currentOrganisationNameTextbox = new System.Windows.Forms.TextBox();
            this.VerificationCodePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.authorisationCodeTextBox = new System.Windows.Forms.TextBox();
            this.CancelAuthorisationCodeButton = new System.Windows.Forms.Button();
            this.ConfirmAuthorisationCodeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.NotConnectedPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ConnectionDetailsPanel.SuspendLayout();
            this.VerificationCodePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "You are not currently connected to Xero";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(108, 26);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(103, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect to Xero";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButtonClick);
            // 
            // NotConnectedPanel
            // 
            this.NotConnectedPanel.Controls.Add(this.label1);
            this.NotConnectedPanel.Controls.Add(this.connectButton);
            this.NotConnectedPanel.Location = new System.Drawing.Point(6, 6);
            this.NotConnectedPanel.Name = "NotConnectedPanel";
            this.NotConnectedPanel.Size = new System.Drawing.Size(316, 53);
            this.NotConnectedPanel.TabIndex = 2;
            this.NotConnectedPanel.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ConnectionDetailsPanel);
            this.tabPage2.Controls.Add(this.VerificationCodePanel);
            this.tabPage2.Controls.Add(this.NotConnectedPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(328, 379);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Connection";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Visible = false;
            // 
            // ConnectionDetailsPanel
            // 
            this.ConnectionDetailsPanel.Controls.Add(this.DisconnectButton);
            this.ConnectionDetailsPanel.Controls.Add(this.label6);
            this.ConnectionDetailsPanel.Controls.Add(this.currentAuthorisationGrantedTextBox);
            this.ConnectionDetailsPanel.Controls.Add(this.label5);
            this.ConnectionDetailsPanel.Controls.Add(this.currentAuthorisationExpiresTextBox);
            this.ConnectionDetailsPanel.Controls.Add(this.label4);
            this.ConnectionDetailsPanel.Controls.Add(this.currentAccessTokenTextBox);
            this.ConnectionDetailsPanel.Controls.Add(this.label3);
            this.ConnectionDetailsPanel.Controls.Add(this.currentOrganisationNameTextbox);
            this.ConnectionDetailsPanel.Location = new System.Drawing.Point(6, 6);
            this.ConnectionDetailsPanel.Name = "ConnectionDetailsPanel";
            this.ConnectionDetailsPanel.Size = new System.Drawing.Size(316, 364);
            this.ConnectionDetailsPanel.TabIndex = 4;
            this.ConnectionDetailsPanel.Visible = false;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(3, 338);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(88, 23);
            this.DisconnectButton.TabIndex = 14;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButtonClick);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Connection created on";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentAuthorisationGrantedTextBox
            // 
            this.currentAuthorisationGrantedTextBox.Location = new System.Drawing.Point(25, 139);
            this.currentAuthorisationGrantedTextBox.Name = "currentAuthorisationGrantedTextBox";
            this.currentAuthorisationGrantedTextBox.Size = new System.Drawing.Size(263, 20);
            this.currentAuthorisationGrantedTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Connection expires on";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentAuthorisationExpiresTextBox
            // 
            this.currentAuthorisationExpiresTextBox.Location = new System.Drawing.Point(25, 193);
            this.currentAuthorisationExpiresTextBox.Name = "currentAuthorisationExpiresTextBox";
            this.currentAuthorisationExpiresTextBox.Size = new System.Drawing.Size(263, 20);
            this.currentAuthorisationExpiresTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current Access Token";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentAccessTokenTextBox
            // 
            this.currentAccessTokenTextBox.Location = new System.Drawing.Point(25, 87);
            this.currentAccessTokenTextBox.Name = "currentAccessTokenTextBox";
            this.currentAccessTokenTextBox.Size = new System.Drawing.Size(263, 20);
            this.currentAccessTokenTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Organisation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentOrganisationNameTextbox
            // 
            this.currentOrganisationNameTextbox.Location = new System.Drawing.Point(25, 35);
            this.currentOrganisationNameTextbox.Name = "currentOrganisationNameTextbox";
            this.currentOrganisationNameTextbox.Size = new System.Drawing.Size(263, 20);
            this.currentOrganisationNameTextbox.TabIndex = 5;
            // 
            // VerificationCodePanel
            // 
            this.VerificationCodePanel.Controls.Add(this.label7);
            this.VerificationCodePanel.Controls.Add(this.authorisationCodeTextBox);
            this.VerificationCodePanel.Controls.Add(this.CancelAuthorisationCodeButton);
            this.VerificationCodePanel.Controls.Add(this.ConfirmAuthorisationCodeButton);
            this.VerificationCodePanel.Controls.Add(this.label2);
            this.VerificationCodePanel.Location = new System.Drawing.Point(6, 65);
            this.VerificationCodePanel.Name = "VerificationCodePanel";
            this.VerificationCodePanel.Size = new System.Drawing.Size(316, 151);
            this.VerificationCodePanel.TabIndex = 3;
            this.VerificationCodePanel.Visible = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 35);
            this.label7.TabIndex = 5;
            this.label7.Text = "Log into Xero using the browser and select an organisation to connect to";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorisationCodeTextBox
            // 
            this.authorisationCodeTextBox.Location = new System.Drawing.Point(108, 78);
            this.authorisationCodeTextBox.Name = "authorisationCodeTextBox";
            this.authorisationCodeTextBox.Size = new System.Drawing.Size(103, 20);
            this.authorisationCodeTextBox.TabIndex = 4;
            // 
            // CancelAuthorisationCodeButton
            // 
            this.CancelAuthorisationCodeButton.Location = new System.Drawing.Point(51, 119);
            this.CancelAuthorisationCodeButton.Name = "CancelAuthorisationCodeButton";
            this.CancelAuthorisationCodeButton.Size = new System.Drawing.Size(103, 23);
            this.CancelAuthorisationCodeButton.TabIndex = 3;
            this.CancelAuthorisationCodeButton.Text = "Cancel";
            this.CancelAuthorisationCodeButton.UseVisualStyleBackColor = true;
            this.CancelAuthorisationCodeButton.Click += new System.EventHandler(this.CancelAuthorisationCodeButtonClick);
            // 
            // ConfirmAuthorisationCodeButton
            // 
            this.ConfirmAuthorisationCodeButton.Location = new System.Drawing.Point(160, 119);
            this.ConfirmAuthorisationCodeButton.Name = "ConfirmAuthorisationCodeButton";
            this.ConfirmAuthorisationCodeButton.Size = new System.Drawing.Size(103, 23);
            this.ConfirmAuthorisationCodeButton.TabIndex = 2;
            this.ConfirmAuthorisationCodeButton.Text = "OK";
            this.ConfirmAuthorisationCodeButton.UseVisualStyleBackColor = true;
            this.ConfirmAuthorisationCodeButton.Click += new System.EventHandler(this.ConfirmAuthorisationCodeButtonClick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the authorisation code from Xero:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(328, 379);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Templates";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 429);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ConfigurationForm";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.ConfigurationFormLoad);
            this.NotConnectedPanel.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ConnectionDetailsPanel.ResumeLayout(false);
            this.ConnectionDetailsPanel.PerformLayout();
            this.VerificationCodePanel.ResumeLayout(false);
            this.VerificationCodePanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Panel NotConnectedPanel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel VerificationCodePanel;
        private System.Windows.Forms.TextBox authorisationCodeTextBox;
        private System.Windows.Forms.Button CancelAuthorisationCodeButton;
        private System.Windows.Forms.Button ConfirmAuthorisationCodeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ConnectionDetailsPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currentAuthorisationExpiresTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentAccessTokenTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currentOrganisationNameTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox currentAuthorisationGrantedTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DisconnectButton;
    }
}