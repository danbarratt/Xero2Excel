using System;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using Xero2Excel.Contracts.Interfaces;
using Xero2Excel.Core.Config;
using XeroApi;
using XeroApi.OAuth;

namespace Xero2Excel.Core.Services
{
    public class ConnectionManager : IConnectionManager
    {
        private readonly ApplicationSettings _applicationSettings;
        private static Repository _currentXeroRepository;

        public ConnectionManager(ApplicationSettings applicationSettings)
        {
            _applicationSettings = applicationSettings;
        }

        public bool VerifyConnection()
        {
            var repository = GetCurrentXeroRepository();

            var currentOrganisation = TryGet(repository, it => it.Organisation);

            return currentOrganisation != null;
        }

        private TModel TryGet<TModel>(Repository repository, Func<Repository, TModel> getModelAction)
            where TModel : XeroApi.Model.EndpointModelBase
        {
            try
            {
                return getModelAction.Invoke(repository);
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        private Repository GetCurrentXeroRepository()
        {
            if (_currentXeroRepository == null)
            {
                string userAgent = string.Format("Xero2Excel v{0} (XeroAPI.Net)", CurrentAssemblyVerison);
                string consumerKey = UserSettings.Default.ConsumerKey;
                X509Certificate2 signingCertificate = _applicationSettings.OAuthSigningCertificate;

                if (string.IsNullOrEmpty(consumerKey))
                    throw new ApplicationException("The OAuth Consumer Key for XeroAPI could not be found");

                if (signingCertificate == null)
                    throw new ApplicationException("The OAuth Signing Certificate for XeroAPI could not be found");

                var oauthSession = new XeroApiPrivateSession(userAgent, consumerKey, signingCertificate);

                _currentXeroRepository = new Repository(oauthSession);
            }

            return _currentXeroRepository;
        }

        private static string CurrentAssemblyVerison
        {
            get { return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }
    }
}
