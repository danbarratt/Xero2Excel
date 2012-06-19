using Xero2Excel.Contracts;
using Xero2Excel.Contracts.Entities;
using Xero2Excel.Contracts.Helpers;
using Xero2Excel.Contracts.Interfaces;

namespace Xero2Excel.Core
{
    public class UserConfigurationManager : IUserConfigurationManager
    {
        public IOAuthToken ConsumerToken
        {
            get
            {
                return new OAuthToken(UserSettings.Default.ConsumerToken);
            }
            set 
            {
                UserSettings.Default.ConsumerToken = value.ToString();
            }
        }

        public IOAuthToken AccessToken
        {
            get
            {
                return new OAuthToken(UserSettings.Default.AccessToken);
            }
            set
            {
                UserSettings.Default.AccessToken = value.ToString();
            }
        }

        public Organisation CurrentOrganisation
        {
            get { return GenericSerializer<Organisation>.Deserialize(UserSettings.Default.Organisation); }
            set { UserSettings.Default.Organisation = GenericSerializer<Organisation>.Serialize(value);  }
        }
    }
}
