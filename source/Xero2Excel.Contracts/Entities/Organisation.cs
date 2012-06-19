using System;
using Xero2Excel.Contracts.Binding;

namespace Xero2Excel.Contracts.Entities
{
    [Serializable]
    public class Organisation : EntityBase
    {
        // GET https://api.xero.com/api.xro/2.0/Organisation/

        /*
            <Organisation>
              <Name>DVB Trial Org</Name>
              <LegalName>DVB Trial Org</LegalName>
              <PaysTax>true</PaysTax>
              <Version>NZ</Version>
              <OrganisationType>COMPANY</OrganisationType>
              <BaseCurrency>NZD</BaseCurrency>
            </Organisation>
        */

        [Bind(Required=true)]
        public string Name;

        [Bind(Required = true)]
        public string LegalName;

        [Bind(Required = true)]
        public bool PaysTax;

        [Bind(Required = true)]
        public string Version;

        [Bind(Required = true)]
        public string OrganisationType;

        [Bind(Required = true)]
        public string BaseCurrency;

        public override Guid? Id
        {
            get { throw new NotImplementedException("Organisation Entity doesn't have an id"); }
        }
    }
}
