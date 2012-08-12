using System;
using System.Globalization;

namespace Xero2Excel.Core.Utilitys
{
    public static class DateTimeExtensions
    {
        public static string FormatUtcTimeForUser(this DateTime? dateTime)
        {
            if (!dateTime.HasValue || DateTime.MaxValue.Equals(dateTime.Value) || DateTime.MinValue.Equals(dateTime.Value))
            {
                return string.Empty;
            }
            
            return dateTime.Value.ToString("R", CultureInfo.CurrentUICulture);
        }
    }
}
