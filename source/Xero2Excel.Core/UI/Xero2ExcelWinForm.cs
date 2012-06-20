using System;
using System.Windows.Forms;
using Xero2Excel.Contracts.Binding;
using Xero2Excel.Contracts.Entities;
using Xero2Excel.Contracts.Interfaces;

namespace Xero2Excel.Core.UI
{
    public partial class Xero2ExcelWinForm : Form
    {
        private readonly IExcelApplicationWrapper _excelApplication;
        private readonly IServiceLocator _serviceLocator;
        private readonly IBindingConfigurationManager _configurationManager;
        
        public Xero2ExcelWinForm(IExcelApplicationWrapper excelApplication, IServiceLocator serviceLocator)
        {
            InitializeComponent();

            _excelApplication = excelApplication;
            _serviceLocator = serviceLocator;

            _configurationManager = serviceLocator.Get<IBindingConfigurationManager>();
            
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
            EntityBase entityBase = (EntityBase) interfaceNameCombobox.SelectedItem;

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
                MessageBox.Show(this,
                                "A field range has not been selected. Select a range before binding to the worksheet.",
                                Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!_excelApplication.IsWorkbookActive)
            {
                MessageBox.Show(this,
                                "There currently isn't an active workbook in Excel. A range cannot be assigned at this time.",
                                Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListViewItem entityFieldListViewItem = interfaceRangeListview.SelectedItems[0];
            BindableField bindableField = (BindableField) entityFieldListViewItem.Tag;

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
        
        private void setupButton_Click(object sender, EventArgs e)
        {
            ConfigurationForm configurationForm = new ConfigurationForm(_serviceLocator);
            configurationForm.ShowDialog(this);
        }
    }
}