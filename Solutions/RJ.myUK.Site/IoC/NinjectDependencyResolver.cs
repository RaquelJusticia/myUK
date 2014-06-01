using System.Web.Http.Dependencies;
using Ninject;

namespace RJ.myUK.Site.IoC
{
    public class NinjectDependencyResolver : NinjectDependencyScope, System.Web.Mvc.IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernel)
            : base(kernel)
        {
            _kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectDependencyScope(_kernel.BeginBlock());
        }
    }
}