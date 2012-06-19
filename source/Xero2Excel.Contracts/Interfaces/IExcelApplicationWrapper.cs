using System.Collections.Generic;

namespace Xero2Excel.Contracts.Interfaces
{
    public interface IExcelApplicationWrapper
    {
        bool IsWorkbookActive { get; }

        string CurrentWorkbookName { get; }

        string GetCurrentSelectedRange { get; }

        IDictionary<string, string> GetAllNamedRanges();

        void SetNamedRange(string rangeName);

        void RemoveNamedRange(string rangeName);

        string GetAddressForNamedRange(string rangeName);
    }
}
