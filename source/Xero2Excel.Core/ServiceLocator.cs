using DevDefined.OAuth.Storage.Basic;
using Ninject;
using Ninject.Modules;
using Xero2Excel.Contracts.Interfaces;
using Xero2Excel.Core.Config;
using Xero2Excel.Core.Services;

namespace Xero2Excel.Core
{
    public class ServiceLocator : IServiceLocator
    {
        public static readonly ServiceLocator Current = new ServiceLocator();

        private readonly IKernel _kernel;

        private ServiceLocator()
        {
            _kernel = new StandardKernel(new CoreModule());
        }
        
        public TService Get<TService>()
        {
            return _kernel.Get<TService>();
        }

        private class CoreModule : NinjectModule 
        {
            public override void Load()
            {
                Bind<IBindingConfigurationManager>().To<BindingConfigurationManager>().InSingletonScope();
                Bind<IConnectionDetails>().To<PublicConnectionDetails>().InSingletonScope();
                Bind<IConnectionManager>().To<ConnectionManager>().InSingletonScope();
                Bind<ITokenRepository>().To<UserSettingsTokenRepository>();
            }
        }

    }
}
