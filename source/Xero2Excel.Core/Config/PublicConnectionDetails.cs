using System.Security.Cryptography.X509Certificates;
using Xero2Excel.Contracts.Interfaces;

namespace Xero2Excel.Core.Config
{
    public class PublicConnectionDetails : IConnectionDetails
    {
        public XeroApiAuthenticationMode AuthenticationMode
        {
            get { return XeroApiAuthenticationMode.Public; }
        }

        public X509Certificate2 OAuthSigningCertificate
        {
            get { return null; }
        }

        public string ConsumerKey
        {
            get { return UserSettings.Default.PublicConsumerKey; }
            set {  }
        }

        public string ConsumerSecret
        {
            get { return UserSettings.Default.PublicConsumerSecret; }
            set {  }
        }

        public string Organisation
        {
            get { return UserSettings.Default.OrganisationJson; }
            set { UserSettings.Default.OrganisationJson = value; }
        }
    }
}
