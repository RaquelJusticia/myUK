using Ninject.Modules;
using RJ.myUK.Site.ServiceLibrary;

namespace RJ.myUK.Site.IoC
{
    public class IoCBinding : NinjectModule
    {
        public override void Load()
        {
            Bind<ICurrencyManager>().To<CurrencyManager>().InSingletonScope();
        }
    }
}