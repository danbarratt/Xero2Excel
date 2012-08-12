using System;

namespace Xero2Excel.Contracts
{
    public class CurrentConnectionDetails
    {
        public string OrganisationName;
        public string AccessToken;
        public DateTime? AccessTokenCreatedUtc;
        public DateTime? AccessTokenExpiresUtc;
    }
}