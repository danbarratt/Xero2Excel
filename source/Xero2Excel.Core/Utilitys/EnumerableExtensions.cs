using System;
using System.Collections.Generic;

namespace Xero2Excel.Core.Utilitys
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
            {
                action.Invoke(item);
            }
        }

    }
}
