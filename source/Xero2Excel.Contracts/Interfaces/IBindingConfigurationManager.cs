using System;
using System.Collections.Generic;

using Xero2Excel.Contracts.Binding;
using Xero2Excel.Contracts.Entities;

namespace Xero2Excel.Contracts.Interfaces
{
    public interface IBindingConfigurationManager
    {
        IEnumerable<EntityBase> GetRegisteredApiEntities();

        IEnumerable<BindableField> GetBindableFieldsFor(EntityBase entity);
    }
}
