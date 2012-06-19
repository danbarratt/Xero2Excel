using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Xero2Excel.Core;
using Microsoft.Office.Core;
using Xero2Excel.UI.Excel2007AddIn;

namespace Xero2Excel2007AddIn {

    [ComVisible(true)]
    public class Xero2ExcelRibbon : IRibbonExtensibility {
        private readonly ThisAddIn _addIn;

        private IRibbonUI _ribbon;
        private Microsoft.Office.Interop.Excel.Application Application
        {
            get { return _addIn.Application; }
        }

        private static Xero2ExcelWinForm _mainForm;

        public Xero2ExcelRibbon(ThisAddIn addIn)
        {
            _addIn = addIn;
        }

        #region IRibbonExtensibility Members

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("Xero2Excel2007AddIn.Xero2ExcelRibbon.xml");
        }

        #endregion

        #region Ribbon Callbacks

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ribbonUI"></param>
        public void OnLoad(IRibbonUI ribbonUI) 
        {
            _ribbon = ribbonUI;
        }

        /// <summary>
        /// Setups the button_ toggle.
        /// </summary>
        /// <param name="control">The control.</param>
        public void SetupButton_Click(IRibbonControl control) 
        {
            try
            {
                if (_mainForm == null || !_mainForm.Visible)
                {
                    if (_mainForm == null)
                    {
                        _mainForm = new Xero2ExcelWinForm(new ExcelApplicationWrapper(Application), ServiceLocator.Current);
                    }

                    _mainForm.Show();
                }
                else 
                {
                    _mainForm.Close();
                    _mainForm = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Xero Add-in could not be started\r\n" + ex);
            }
        }

        #endregion

        #region Helpers

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resourceName"></param>
        /// <returns></returns>
        private static string GetResourceText(string resourceName) 
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();

            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        return resourceReader.ReadToEnd();
                    }
                }
            }
            return null;
        }

        #endregion
    }
}
