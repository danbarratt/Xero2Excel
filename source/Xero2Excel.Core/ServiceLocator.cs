using Ninject;
using Ninject.Modules;
using Xero2Excel.Contracts.Interfaces;

namespace Xero2Excel.Core
{
    public class ServiceLocator
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
                Bind<IUserConfigurationManager>().To<UserConfigurationManager>().InSingletonScope();
                //Bind<IXeroWebProxy>().To<XeroOAuthWebProxy>();
            }
        }

    }
}
