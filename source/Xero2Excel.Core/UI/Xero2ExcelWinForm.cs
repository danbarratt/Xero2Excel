using System;
using System.Windows.Forms;
using Xero2Excel.Contracts.Binding;
using Xero2Excel.Contracts.Entities;
using Xero2Excel.Contracts.Interfaces;
using Xero2Excel.Core;

namespace Xero2Excel.UI.Excel2007AddIn {

    /// <summary>
    /// 
    /// </summary>
    public partial class Xero2ExcelWinForm : Form {

        private readonly IExcelApplicationWrapper _excelApplication;
        private readonly IBindingConfigurationManager _configurationManager;
        private readonly IUserConfigurationManager _userConfigurationManager;

        /// <summary>
        /// 
        /// </summary>
        public Xero2ExcelWinForm(IExcelApplicationWrapper excelApplication, ServiceLocator serviceLocator)
        {
            InitializeComponent();

            _excelApplication = excelApplication;
            _configurationManager = serviceLocator.Get<IBindingConfigurationManager>();
            _userConfigurationManager = serviceLocator.Get<IUserConfigurationManager>();

            // Populate the list of interface names
            foreach (EntityBase entity in _configurationManager.GetRegisteredApiEntities())
            {
                interfaceNameCombobox.Items.Add(entity);
            }

            // Select the first item in the list
            if (interfaceNameCombobox.Items.Count > 0)
            {
                interfaceNameCombobox.SelectedIndex = 0;
            }

            // Show the current connection details
            RefreshConnectionDetails();
        }


        private void RefreshConnectionDetails()
        {
            Organisation currentOrganisation = _userConfigurationManager.CurrentOrganisation;

            setupCurrentOrganisationTextbox.Text = currentOrganisation == null 
                ? string.Empty 
                : currentOrganisation.Name;

            setupConnectionStatusLabel.Text = _userConfigurationManager.AccessToken == null
                ? "You are currently not connected to Xero"
                : "You have succesfully connected to Xero";

            setupConsumerKeyTextbox.Text = _userConfigurationManager.ConsumerToken.Key;
            setupConsumerSecretTextbox.Text = _userConfigurationManager.ConsumerToken.Secret;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the interfaceNameCombobox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void interfaceNameCombobox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            RefreshBoundFieldRanges();
        }

        private void RefreshBoundFieldRanges()
        {
            EntityBase entityBase = (EntityBase)interfaceNameCombobox.SelectedItem;

            // ListView
            interfaceRangeListview.Items.Clear();
            foreach (BindableField bindableField in _configurationManager.GetBindableFieldsFor(entityBase))
            {
                bindableField.GetRangeAddressFromWorksheet(_excelApplication);

                ListViewItem bindableFieldLvi = bindableField.ToListViewItem();
                interfaceRangeListview.Items.Add(bindableFieldLvi);
            }
        }

        /// <summary>
        /// Handles the Click event of the fieldRangesBindButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void fieldRangesBindButton_Click(object sender, EventArgs e)
        {
            if (interfaceRangeListview.SelectedItems.Count <= 0)
            {
                MessageBox.Show(this, "A field range has not been selected. Select a range before binding to the worksheet.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!_excelApplication.IsWorkbookActive)
            {
                MessageBox.Show(this, "There currently isn't an active workbook in Excel. A range cannot be assigned at this time.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            ListViewItem entityFieldListViewItem = interfaceRangeListview.SelectedItems[0];
            BindableField bindableField = (BindableField) entityFieldListViewItem.Tag;

            // Set the range name on the selected fields
            _excelApplication.SetNamedRange(bindableField.RangeName);

            // Refresh the bindings 
            RefreshBoundFieldRanges();
        }

        /// <summary>
        /// Handles the Click event of the fieldRangesUnbindButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void fieldRangesUnbindButton_Click(object sender, EventArgs e)
        {
            if (interfaceRangeListview.SelectedItems.Count <= 0)
            {
                MessageBox.Show(this, "A field range has not been selected. Select a range before binding to the worksheet.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!_excelApplication.IsWorkbookActive)
            {
                MessageBox.Show(this, "There currently isn't an active workbook in Excel. A range cannot be assigned at this time.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            ListViewItem entityFieldListViewItem = interfaceRangeListview.SelectedItems[0];
            BindableField bindableField = (BindableField)entityFieldListViewItem.Tag;

            // Set the range name on the selected fields
            _excelApplication.RemoveNamedRange(bindableField.RangeName);

            // Refresh the bindings 
            RefreshBoundFieldRanges();
        }

        private void Xero2ExcelWinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hide the form
            Form form = (Form) sender;
            form.Visible = false;

            // Don't close the window down
            e.Cancel = true;
        }

        private void setupConnectButton_Click(object sender, EventArgs e)
        {
            
        }


    }
}