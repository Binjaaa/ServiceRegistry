[assembly: WebActivator.PreApplicationStartMethod(typeof(SRR.UI.MVC4.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(SRR.UI.MVC4.App_Start.NinjectWebCommon), "Stop")]

namespace SRR.UI.MVC4.App_Start
{
    using System;
    using System.Web;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using SRR.Contracts.DAL.Repositories;
    using SRR.DataAccessLayer;
    using SRR.DataAccessLayer.Repositories;
    using SRR.Infrastructure.Contracts.DAL;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            
            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            //kernel.Bind<ILogService>().To<DebugLogService>();
            kernel.Bind<IDbContext>().To<Entities>();
            kernel.Bind<IApplicationRepository>().To<ApplicationRepository>();
            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<ISRREntityTagRepository>().To<SRREntityTagRepository>();
        }        
    }
}
