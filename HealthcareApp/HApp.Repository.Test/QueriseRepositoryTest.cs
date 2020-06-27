using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;
using HApp.Domain;
using HApp.Repository;
namespace HApp.Repository.Test
{
    [TestClass]
    public class QueriseRepositoryTest
    {

        private TransactionScope transactionScope;
        private HappContext dbContext;
        private QueriseRepository repository;
        private Querise querise;
        private string sessionKey = "S@12345678";
        private Guid Id = new Guid("32cc3858-b1f0-48b2-ace4-dca10a197968");

        [TestInitialize]
        public void TestInitialize()
        {
            transactionScope = new TransactionScope();
            dbContext = new HappContext();
            repository = new QueriseRepository(dbContext);
            querise = new Querise()
            {
                EID = Guid.NewGuid(),
                DID = Id,
                SessionKey = sessionKey
            };
        }

        [TestCleanup]
        public void TestDispose()
        {
            transactionScope.Dispose();
            transactionScope = null;
            dbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        [TestMethod]
        public void AddTest()
        {
            repository.Add(querise);
            bool result = dbContext.SaveChanges() > 0;
            Assert.IsTrue(result);
            Transaction.Current.Rollback();
        }

        [TestMethod]
        public void FindByDIDTest()
        {
            repository.Add(querise);
            IList<Querise> result = repository.FindByDoctorID(Id);
            Assert.IsTrue(result.Count == 1 && result.Contains(querise) && result[0].DID == Id);
            Transaction.Current.Rollback();
        }

        [TestMethod]
        public void RemoveTest()
        {
            repository.Add(querise);
            bool result = dbContext.SaveChanges() > 0;
            repository.Remove(querise);
            result = dbContext.SaveChanges() > 0;
            Assert.IsTrue(result);
            Transaction.Current.Rollback();
        }
    }
}
