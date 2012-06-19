using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xero2Excel.Contracts.Interfaces
{
    public interface IApiConnectionManager
    {

        void ValidateConnectionToApi();

        void ConnectToApiUsingOAuth();

    }
}
