using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using Xero2Excel.Contracts.Interfaces;

namespace Xero2Excel2007AddIn
{
    public class ExcelApplicationWrapper : IExcelApplicationWrapper
    {
        private readonly Application _application;

        public ExcelApplicationWrapper(Application application)
        {
            _application = application;
        }

        public bool IsWorkbookActive
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

        public string GetCurrentSelectedRange
        {
            get
            {
                Range selection = (Range)_application.Selection;
                return selection.Address[true, true, XlReferenceStyle.xlA1, Type.Missing, Type.Missing];
            }
        }

        public IDictionary<string, string> GetAllNamedRanges()
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

        public void SetNamedRange(string rangeName)
        {
            Range selection = _application.Selection as Range;
            selection.Name = rangeName;
        }

        public void RemoveNamedRange(string rangeName)
        {
            Worksheet activeSheet = (Worksheet)_application.ActiveSheet;

            try
            {
                Range range = activeSheet.Range[rangeName, Type.Missing];
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
                Range range = activeSheet.Range[rangeName, Type.Missing];
                return range.Address[true, true, XlReferenceStyle.xlA1, Type.Missing, Type.Missing];
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
