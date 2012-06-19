using System;

namespace Xero2Excel.Contracts.Binding
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class BindAttribute : Attribute
    {
        public bool Required
        {
            get;
            set;
        }
    }
}
