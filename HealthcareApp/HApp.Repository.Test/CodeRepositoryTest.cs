using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HApp.Repository;
using HApp.Domain;
using System.Collections.Generic;
using System.Transactions;

namespace HApp.Repository.Test
{
    [TestClass]
    public class CodeRepositoryTest
    {
        private TransactionScope transactionScope;
        private HappContext dbContext;
        private CodeRepository repository;
        private Code code;
        string pubKey = "P@123456789";
        string priKey = "P@12345678";
        string sessionKey = "S@12345678";

        [TestInitialize]
        public void TestInitialize()
        {
            transactionScope = new TransactionScope();
            dbContext = new HappContext();
            repository = new CodeRepository(dbContext);
            code = new Code() { Cprikey = priKey, Cpubkey = pubKey, SessionKey = sessionKey };
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
            repository.Add(code);
            bool result = dbContext.SaveChanges() > 0;
            Assert.IsTrue(result);
            Transaction.Current.Rollback();
        }

        [TestMethod]
        public void FindByKeyTest()
        {
            repository.Add(code);
            Code result = repository.FindByKey(sessionKey);
            Assert.IsTrue(result.SessionKey == sessionKey);
            Transaction.Current.Rollback();
        }

        [TestMethod]
        public void RemoveTest()
        {
            repository.Add(code);
            bool result = dbContext.SaveChanges() > 0;
            repository.Remove(code);
            result = dbContext.SaveChanges() > 0;
            Assert.IsTrue(result);
            Transaction.Current.Rollback();
        }
    }
}
