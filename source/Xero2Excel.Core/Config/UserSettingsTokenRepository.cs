using System;
using DevDefined.OAuth.Storage.Basic;
using Newtonsoft.Json;

namespace Xero2Excel.Core.Config
{
    class UserSettingsTokenRepository : ITokenRepository
    {
        public RequestToken GetRequestToken()
        {
            string json = UserSettings.Default.RequestTokenJson;

            return string.IsNullOrEmpty(json) 
                ? null :
                JsonConvert.DeserializeObject<RequestToken>(json);
        }

        public void SaveRequestToken(RequestToken requestToken)
        {
            UserSettings.Default.RequestTokenJson = (requestToken == null)
                ? string.Empty
                : JsonConvert.SerializeObject(requestToken, Formatting.None);
        }

        public AccessToken GetAccessToken()
        {
            string json = UserSettings.Default.AccessTokenJson;

            return string.IsNullOrEmpty(json)
                ? null :
                JsonConvert.DeserializeObject<AccessToken>(json);
        }

        public void SaveAccessToken(AccessToken accessToken)
        {
            UserSettings.Default.AccessTokenJson = (accessToken == null)
                ? string.Empty
                : JsonConvert.SerializeObject(accessToken, Formatting.None);
        }
    }
}
