using System;
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
            foreach (Type objectType in entityAssembly.GetTypes())
            {
                if (objectType.IsSubclassOf(typeof (EntityBase)))
                {
                    yield return (EntityBase)Activator.CreateInstance(objectType);
                }
            }
        }

        public IEnumerable<BindableField> GetBindableFieldsFor(EntityBase entity)
        {
            Type entityType = entity.GetType();

            foreach (MemberInfo memberInfo in entityType.FindMembers(MemberTypes.Field | MemberTypes.Property, BindingFlags.Public | BindingFlags.Instance, null, null))
            {
                foreach (BindAttribute bindAttribute in memberInfo.GetCustomAttributes(typeof(BindAttribute), false))
                {
                    string propName = memberInfo.Name;
                    Type propType = memberInfo.ReflectedType;
                    bool isRequired = bindAttribute.Required;
                    
                    yield return new BindableField() 
                    {
                        FieldName = propName, 
                        FieldType = propType, 
                        IsRequired = isRequired, 
                        ParentEntity = entity
                    };
                }
            }
        }

    }
}
