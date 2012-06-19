using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xero2Excel.Contracts.Entities;

namespace Xero2Excel.Contracts.Interfaces
{
    public interface IUserConfigurationManager
    {

        IOAuthToken ConsumerToken
        {
            get; set;
        }

        IOAuthToken AccessToken
        {
            get; set;
        }

        Organisation CurrentOrganisation
        {
            get; set;
        }

    }
}
