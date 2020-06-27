using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;
using HApp.Domain;
using HApp.Repository;

namespace HApp.Repository.Test
{
    [TestClass]
    public class DoctorRepositoryTest
    {
        private TransactionScope transactionScope;
        private HappContext dbContext;
        private DoctorRepository repository;
        private Doctor doctor;

        private Guid Id = new Guid("32cc3858-b1f0-48b2-ace4-dca10a197964");
        string pubKey = "P@123456789";
        string priKey = "P@12345678";
        string name = "xxxxxxxxx";

        [TestInitialize]
        public void TestInitialize()
        {
            transactionScope = new TransactionScope();
            dbContext = new HappContext();
            repository = new DoctorRepository(dbContext);
            doctor = new Doctor() { ID = Id, privateKey = priKey, PublicKey = pubKey, Name = name };
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
            repository.Add(doctor);

            bool result = dbContext.SaveChanges() > 0;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void FindByKeyTest()
        {
            repository.Add(doctor);
            Doctor result = repository.FindById(Id);
            Assert.IsTrue(result.ID == Id);
        }

        [TestMethod]
        public void ModifyTest()
        {
            repository.Add(doctor);
            Doctor doctorForModify = new Doctor() { ID = Id, privateKey = "P@87654321", PublicKey = "P@987654321", Name = "xxxxx" };
            repository.Modify(doctorForModify);
            Doctor result = repository.FindById(Id);
            Assert.IsTrue(result.PublicKey== "P@987654321" && result.privateKey== "P@87654321" && result.Name=="xxxxx");
        }

        [TestMethod]
        public void RemoveTest()
        {
            repository.Add(doctor);
            bool result = dbContext.SaveChanges() > 0;
            repository.Remove(doctor);
            result = dbContext.SaveChanges() > 0;
            Assert.IsTrue(result);
        }
    }
}
