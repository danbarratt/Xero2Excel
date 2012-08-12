using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xero2Excel.Core.Exceptions
{
    class MissingCertificateException : ConfigurationException
    {
        public MissingCertificateException(string message) : base(message)
        {
            
        }
    }

    class MissingOAuthCredentialsException : ConfigurationException
    {
        public MissingOAuthCredentialsException(string message) : base(message)
        {
            
        }
    }

    class ConfigurationException : Exception
    {
        public ConfigurationException()
        {
            
        }

        public ConfigurationException(string message) : base(message)
        {
            
        }
    }
}
