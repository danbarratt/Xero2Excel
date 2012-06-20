using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Xero2Excel.Core;
using Microsoft.Office.Core;
using Xero2Excel.Core.UI;

namespace Xero2Excel2007AddIn
{

    [ComVisible(true)]
    public class Xero2ExcelRibbon : IRibbonExtensibility
    {
        private Xero2ExcelWinForm _mainForm;
        private readonly ThisAddIn _addIn;

        private Microsoft.Office.Interop.Excel.Application Application
        {
            get { return _addIn.Application; }
        }

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
        }
        
        private static void ShowGeneralError(Exception ex)
        {
            MessageBox.Show("The Xero Add-in could not be started\r\n" + ex);
        }

        public void OpenMainForm_Click(IRibbonControl ribbon)
        {
            try
            {
                if (_mainForm == null)
                {
                    _mainForm = new Xero2ExcelWinForm(new ExcelApplicationWrapper(Application), ServiceLocator.Current);
                }

                if (!_mainForm.Visible)
                {
                    _mainForm.Show();
                }
            }
            catch (Exception ex)
            {
                ShowGeneralError(ex);
            }
        }

        #endregion

        #region Helpers

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();

            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (
                        StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
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