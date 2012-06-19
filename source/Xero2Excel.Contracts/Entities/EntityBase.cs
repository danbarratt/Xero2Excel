using System;
using System.Xml.Serialization;

namespace Xero2Excel.Contracts.Entities
{
    public abstract class EntityBase
    {

        [XmlIgnore]
        public virtual string SingularEntityName
        {
            get { return GetType().Name; } 
        }

        [XmlIgnore]
        public virtual string PluralEntityName
        {
            get { return string.Format("{0}s", SingularEntityName); }
        }

        [XmlIgnore]
        public abstract Guid? Id
        {
            get;
        }

        public override string ToString()
        {
            return SingularEntityName;
        }

    }
}
