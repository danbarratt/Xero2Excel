using System;
using System.Globalization;
using System.Windows.Forms;
using Xero2Excel.Contracts.Entities;
using Xero2Excel.Contracts.Interfaces;

namespace Xero2Excel.Contracts.Binding
{
    public class BindableField
    {
        public EntityBase ParentEntity { get; set; }

        public string FieldName { get; set; }

        public Type FieldType { get; set; }

        public bool IsRequired { get; set; }

        public bool IsMultiField { get; set; }

        public string RangeAddress { get; set; }

        public string RangeName
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "{0}.{1}", ParentEntity.SingularEntityName, FieldName);
            }
        }

        public void GetRangeAddressFromWorksheet(IExcelApplicationWrapper excelApplication)
        {
            RangeAddress = excelApplication.GetAddressForNamedRange(RangeName);
        }

        public ListViewItem ToListViewItem()
        {
            return new ListViewItem(new [] {FieldName, IsRequired.ToString(), IsMultiField.ToString(), RangeAddress}) { Tag = this };
        }

    }
}
