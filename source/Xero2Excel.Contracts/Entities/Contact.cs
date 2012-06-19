using System;
using System.Xml.Serialization;
using Xero2Excel.Contracts.Binding;

namespace Xero2Excel.Contracts.Entities
{
    public class Contact : EntityBase 
    {

        // https://api.xero.com/api.xro/2.0/Contacts

        /*
        <Contact>
          <ContactID>9c205f35-580b-4234-8997-4531cb945812</ContactID>
          <ContactStatus>ACTIVE</ContactStatus>
          <Name>Stevie Jobsian</Name>
          <Addresses>
            <Address>
              <AddressType>STREET</AddressType>
            </Address>
            <Address>
              <AddressType>POBOX</AddressType>
            </Address>
          </Addresses>
          <Phones>
            <Phone>
              <PhoneType>DEFAULT</PhoneType>
            </Phone>
            <Phone>
              <PhoneType>DDI</PhoneType>
            </Phone>
            <Phone>
              <PhoneType>FAX</PhoneType>
            </Phone>
            <Phone>
              <PhoneType>MOBILE</PhoneType>
            </Phone>
          </Phones>
          <UpdatedDateUTC>2010-02-05T01:18:17.737</UpdatedDateUTC>
          <IsSupplier>false</IsSupplier>
          <IsCustomer>false</IsCustomer>
        </Contact>
        */

        [Bind(Required = false)]
        public override Guid? Id
        {
            get { return ContactId; }
        }

        [Bind(Required = false)]
        public Guid? ContactId;

        [Bind(Required = true)]
        public string Name;

        [XmlArray(IsNullable=true)]
        public Address[] Addresses;
        
        [XmlArray(IsNullable = true)]
        public Phone[] Phones;
    }
}
