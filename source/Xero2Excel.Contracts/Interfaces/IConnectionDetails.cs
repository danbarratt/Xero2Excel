using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace Xero2Excel.Contracts.Interfaces
{
    public enum XeroApiAuthenticationMode
    {
        Public,
        Private,
        Partner
    }

    public interface IConnectionDetails
    {
        XeroApiAuthenticationMode AuthenticationMode { get; }

        X509Certificate2 OAuthSigningCertificate { get; }

        string ConsumerKey { get; }

        string ConsumerSecret { get; }
        
        string Organisation { get; set; }
    }
}
