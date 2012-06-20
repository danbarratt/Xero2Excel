using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

using Xero2Excel.Contracts.Binding;
using Xero2Excel.Contracts.Entities;
using Xero2Excel.Contracts.Interfaces;

namespace Xero2Excel.Core
{
    public class BindingConfigurationManager : IBindingConfigurationManager
    {
        public IEnumerable<EntityBase> GetRegisteredApiEntities()
        {
            Assembly entityAssembly = typeof (EntityBase).Assembly;

            return entityAssembly.GetTypes()
                    .Where(objectType => objectType.IsSubclassOf(typeof (EntityBase)))
                    .Select(objectType => (EntityBase) Activator.CreateInstance(objectType));
        }

        public IEnumerable<BindableField> GetBindableFieldsFor(EntityBase entity)
        {
            MemberInfo[] members = entity.GetType().FindMembers(MemberTypes.Field | MemberTypes.Property, BindingFlags.Public | BindingFlags.Instance, null, null);

            foreach (MemberInfo memberInfo in members)
            {
                foreach (BindAttribute bindAttribute in memberInfo.GetCustomAttributes(typeof(BindAttribute), false))
                {
                    yield return new BindableField
                    {
                        FieldName = memberInfo.Name, 
                        FieldType = memberInfo.ReflectedType, 
                        IsRequired = bindAttribute.Required, 
                        ParentEntity = entity
                    };
                }
            }
        }

    }
}
