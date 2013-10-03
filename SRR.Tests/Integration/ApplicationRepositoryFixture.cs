using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SRR.Contracts.DAL.Repositories;
using SRR.DataAccessLayer.Repositories;

namespace SRR.Tests.Integration
{
    [TestFixture]
    internal class ApplicationRepositoryFixture
    {
        IApplicationRepository _integrationApplicationRepo;
        IUserRepository _integrationUserRepo;
        IEntityTagRepository _integrationTagRepo;

        [SetUp]
        public void SetUp()
        {
            _integrationApplicationRepo = (IApplicationRepository)ConfigIntegrationTestContext.iocKernelTestContext.GetService(typeof(IApplicationRepository));
            _integrationUserRepo = (IUserRepository)ConfigIntegrationTestContext.iocKernelTestContext.GetService(typeof(IUserRepository));
            _integrationTagRepo = (IEntityTagRepository)ConfigIntegrationTestContext.iocKernelTestContext.GetService(typeof(IEntityTagRepository));
        }

        [Test]
        public void TryToGetApplicationFromDB()
        {
            var res = _integrationApplicationRepo.All().FirstOrDefault();
            Assert.IsNotNull(res);
        }

        [Test]
        public void TryToUpdateApplication_WithColumnValue()
        {
            var res = _integrationApplicationRepo.All().FirstOrDefault();
            res.Name = "TryToUpdateApplication";

            _integrationApplicationRepo.Update(res);
            _integrationApplicationRepo.Save();
        }

        [Test]
        public void TryToUpdateApplication_WithForeignKeyValue()
        {
            var res = _integrationApplicationRepo.All().FirstOrDefault();
            Debug.WriteLine(String.Format("Developer ID: {0}", res.FK_Developer));

            var user = _integrationUserRepo.All().FirstOrDefault();
            Debug.WriteLine(String.Format("Update Developer ID: {0}", user.PK_ID));
            res.Developer = user;

            _integrationApplicationRepo.Update(res);
            _integrationApplicationRepo.Save();
        }

        [Test]
        public void TryToUpdateApplication_WithN2NRelationForeignKeyValueWithANewOne()
        {
            var res = _integrationApplicationRepo.All().FirstOrDefault();
            Debug.WriteLine(String.Format("Developer ID: {0}", res.FK_Developer));

            var listOfTags = res.Tags.ToList();

            var tagIDs = listOfTags.Select(p => p.PK_ID).ToList();
            var newTags = _integrationTagRepo.Find(p => tagIDs.Contains(p.PK_ID) == false).Take(3);

            foreach (var currentNewTag in newTags)
            {
                res.Tags.Add(currentNewTag);
            }
            _integrationApplicationRepo.Update(res);
            _integrationApplicationRepo.Save();
        }
    }
}
