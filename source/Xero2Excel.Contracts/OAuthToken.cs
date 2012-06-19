using System;
using Xero2Excel.Contracts.Interfaces;

namespace Xero2Excel.Contracts
{
    [Serializable]
    public class OAuthToken : IOAuthToken
    {
        public OAuthToken(string key, string secret)
        {
            Key = key;
            Secret = secret;
        }

        public OAuthToken(string tokenString)
        {
            if (string.IsNullOrEmpty(tokenString))
            {
                return;
            }

            string[] tokenStringParts = tokenString.Split(',');

            if (tokenStringParts.Length == 3)
            {
                Key = tokenStringParts[1].Substring(tokenStringParts[1].IndexOf("=") + 1);
                Secret = tokenStringParts[2].Substring(tokenStringParts[2].IndexOf("=") + 1);
            }
        }

        public string Key
        {
            get;
            set;
        }

        public string Secret
        { 
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("OAuthToken, Key={0}, Secret={1}", Key, Secret);
        }
    }
}
