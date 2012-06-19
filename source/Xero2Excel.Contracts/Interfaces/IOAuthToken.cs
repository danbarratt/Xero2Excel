using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xero2Excel.Contracts.Interfaces
{
    public interface IOAuthToken
    {

        string Key { get; set; }

        string Secret { get; set; }

    }
}
