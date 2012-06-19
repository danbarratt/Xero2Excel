using System.Collections.Generic;

namespace Xero2Excel.Contracts.Interfaces
{
    public interface IExcelApplicationWrapper
    {
        bool WorkbookIsActive { get; }
        string CurrentWorkbookName { get; }
        string CurrentWorkbookSelectedRange { get; }
        IDictionary<string, string> CurrentWorkbookNamedRanges();

        void DefineNamedRangeForSelection(string rangeName);
        void RemoveNamedRange(string rangeName);

        string GetAddressForNamedRange(string rangeName);
    }
}
