using System;
using System.Diagnostics;
using DevDefined.OAuth.Consumer;
using DevDefined.OAuth.Storage.Basic;
using Newtonsoft.Json;
using Xero2Excel.Contracts;
using Xero2Excel.Contracts.Interfaces;
using Xero2Excel.Core.Exceptions;
using XeroApi;
using XeroApi.OAuth;

namespace Xero2Excel.Core.Services
{
    public class ConnectionManager : IConnectionManager
    {
        private readonly IConnectionDetails _connectionDetails;
        private readonly ITokenRepository _tokenRepository;

        private Repository _xeroapiRepository;
        private OAuthSession _oauthSession;

        public ConnectionManager(IConnectionDetails connectionDetails, ITokenRepository tokenRepository)
        {
            _connectionDetails = connectionDetails;
            _tokenRepository = tokenRepository;
        }

        public bool VerifyConnection()
        {
            try
            {
                var currentOrganisation = TryGet(it => it.Organisation);

                return currentOrganisation != null;
            }
            catch (ConfigurationException)
            {
                return false;
            }
        }

        public Uri InitialiseConnection()
        {
            var session = GetCurrentOAuthSession();

            RequestToken requestToken = session.GetRequestToken();

            Debug.WriteLine("Request Token: " + JsonConvert.SerializeObject(requestToken));

            string url = session.GetUserAuthorizationUrl();

            Debug.WriteLine("Authorisation URL: " + url);

            return new Uri(url);
        }

        public void ResetConnection()
        {
            CurrentOrganisation = null;
            _tokenRepository.SaveRequestToken(null);
            _tokenRepository.SaveAccessToken(null);
        }

        public void FinaliseConnection(string oauthVerifier)
        {
            var session = GetCurrentOAuthSession();

            var accessToken = session.ExchangeRequestTokenForAccessToken(oauthVerifier);

            Debug.WriteLine("Access Token: " + JsonConvert.SerializeObject(accessToken));

            CurrentOrganisation = TryGet(repo => repo.Organisation);

            UserSettings.Default.Save();
        }

        public CurrentConnectionDetails GetCurrentConnectionDetails()
        {
            var accessToken = _tokenRepository.GetAccessToken();

            var organisation = CurrentOrganisation;
            
            return new CurrentConnectionDetails
            {
                OrganisationName = organisation == null ? string.Empty : organisation.Name,
                AccessTokenCreatedUtc = accessToken.CreatedDateUtc,
                AccessToken = accessToken.Token,
                AccessTokenExpiresUtc = accessToken.SessionExpiryDateUtc ?? accessToken.ExpiryDateUtc
            };
        }

        public XeroApi.Model.Organisation CurrentOrganisation
        {
            get
            {
                return string.IsNullOrEmpty(_connectionDetails.Organisation)
                    ? null
                    : JsonConvert.DeserializeObject<XeroApi.Model.Organisation>(_connectionDetails.Organisation);
            }
            set
            {
                var organisationJson = (value == null)
                    ? string.Empty
                    : JsonConvert.SerializeObject(value);

                Debug.WriteLine("Organisation: " + organisationJson);

                _connectionDetails.Organisation = organisationJson;
            }
        }

        private TModel TryGet<TModel>(Func<Repository, TModel> getModelAction)
            where TModel : XeroApi.Model.EndpointModelBase
        {
            var repository = GetCurrentXeroRepository();

            try
            {
                return getModelAction.Invoke(repository);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ConnectionManager.TryGet failed: " + ex.Message);

                return null;
            }
        }
        
        private OAuthSession GetCurrentOAuthSession()
        {
            return _oauthSession ?? (_oauthSession = NewApiSession());
        }

        private OAuthSession NewApiSession()
        {
            var userAgent = string.Format("Xero2Excel v{0} (XeroAPI.Net)", CurrentAssemblyVerison);
            var consumerKey = _connectionDetails.ConsumerKey;
            var consumerSecret = _connectionDetails.ConsumerSecret;
            var signingCertificate = _connectionDetails.OAuthSigningCertificate;

            if (string.IsNullOrEmpty(consumerKey))
                throw new MissingOAuthCredentialsException("The OAuth Consumer Key for XeroAPI could not be found");

            switch (_connectionDetails.AuthenticationMode)
            {
                case XeroApiAuthenticationMode.Public:
                    return new XeroApiPublicSession(userAgent, consumerKey, consumerSecret, _tokenRepository);

                case XeroApiAuthenticationMode.Private:
                    return new XeroApiPrivateSession(userAgent, consumerKey, signingCertificate);

                default:
                    var message = string.Format("The XeroApiAuthenticationMode {0} is not currently supported",
                                                _connectionDetails.AuthenticationMode);
                    throw new ConfigurationException(message);
            }
        }

        private Repository GetCurrentXeroRepository()
        {
            return _xeroapiRepository ?? (_xeroapiRepository = NewApiRepository());
        }

        private Repository NewApiRepository()
        {
            var oauthSession = GetCurrentOAuthSession();
            return new Repository(oauthSession);
        }

        private static string CurrentAssemblyVerison
        {
            get { return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }
    }
}
