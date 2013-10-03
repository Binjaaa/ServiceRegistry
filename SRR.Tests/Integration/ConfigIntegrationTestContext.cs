using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using NUnit.Framework;
using SRR.Contracts.DAL.Repositories;
using SRR.DataAccessLayer;
using SRR.DataAccessLayer.Repositories;
using SRR.Infrastructure.Contracts.DAL;

namespace SRR.Tests.Integration
{
    [SetUpFixture]
    internal class ConfigIntegrationTestContext
    {
        public static IKernel iocKernelTestContext;

        [SetUp]
        public void SetUp()
        {
            //iocKernelTestContext = NinjectWebCommon.CreateKernel();
            iocKernelTestContext = new StandardKernel();

            //DB Context
            iocKernelTestContext.Bind<IDbContext>().To<Entities>().InSingletonScope();

            //Repositories
            iocKernelTestContext.Bind<IApplicationRepository>().To<SRRApplicationRepository>();
            iocKernelTestContext.Bind<IUserRepository>().To<SRRUserRepository>();
            iocKernelTestContext.Bind<IEntityTagRepository>().To<SRREntityTagRepository>();
            //iocKernelTestContext.Bind<IEntityTypeRepository>().To<SRREntityTypeRepository>();
            iocKernelTestContext.Bind<IServiceMessageRepository>().To<SRRServiceMessageRepository>();
            iocKernelTestContext.Bind<IServiceOperationRepository>().To<SRRServiceOperationRepository>();
            iocKernelTestContext.Bind<IServicesRepository>().To<SRRServiceRepository>();
        }

        [TearDown]
        public void TearDown()
        {
            iocKernelTestContext.Dispose();
        }
    }
}
