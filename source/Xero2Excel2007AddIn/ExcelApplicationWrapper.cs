using System;
using System.Collections.Generic;

using Microsoft.Office.Interop.Excel;
using Xero2Excel.Contracts.Interfaces;

namespace Xero2Excel.UI.Excel2007AddIn
{
    public class ExcelApplicationWrapper : IExcelApplicationWrapper
    {
        private readonly Application _application;

        public ExcelApplicationWrapper(Application application)
        {
            _application = application;
        }

        public bool WorkbookIsActive
        {
            get
            {
                return (_application != null) && (_application.ActiveWorkbook != null);
            }
        }

        public string CurrentWorkbookName
        {
            get
            {
                return _application.ActiveWorkbook.Name;
            }
        }

        public string CurrentWorkbookSelectedRange
        {
            get
            {
                Range selection = _application.Selection as Range;
                return selection.get_Address(true, true, XlReferenceStyle.xlA1, Type.Missing, Type.Missing);
            }
        }

        public IDictionary<string, string> CurrentWorkbookNamedRanges()
        {
            Dictionary<string, string> namedRanges = new Dictionary<string, string>();

            Workbook workbook = _application.ActiveWorkbook;

            if (workbook.Names.Count != 0)
            {
                foreach (Name namedRange in workbook.Names)
                {
                    namedRanges.Add(namedRange.Name, namedRange.Value);
                }
            }

            return namedRanges;
        }

        public void DefineNamedRangeForSelection(string rangeName)
        {
            Range selection = _application.Selection as Range;
            selection.Name = rangeName;
        }

        public void RemoveNamedRange(string rangeName)
        {
            Worksheet activeSheet = (Worksheet)_application.ActiveSheet;

            try
            {
                Range range = activeSheet.get_Range(rangeName, Type.Missing);
                Name name = (Name)range.Name;
                name.Delete();
            }
            catch (Exception)
            {
                // Supress the exception
            }
        }

        public string GetAddressForNamedRange(string rangeName)
        {
            Worksheet activeSheet = (Worksheet)_application.ActiveSheet;

            try
            {
                Range range = activeSheet.get_Range(rangeName, Type.Missing);
                return range.get_Address(true, true, XlReferenceStyle.xlA1, Type.Missing, Type.Missing);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
