using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;
using HApp.Domain;
using HApp.Repository;

namespace HApp.Repository.Test
{
    [TestClass]
    public class SessionRepositoryTest
    {
        private TransactionScope transactionScope;
        private HappContext dbContext;
        private SessionRepository repository;
        private Session session;
        private Doctor doctor;
        private Patient patient;

        [TestInitialize]
        public void TestInitialize()
        {
            transactionScope = new TransactionScope();
            dbContext = new HappContext();
            repository = new SessionRepository(dbContext);
            doctor = new Doctor() {ID = Guid.NewGuid() };
            patient = new Patient() {ID = Guid.NewGuid() };
            session = new Session() {
                PID = patient.ID,
                DID = doctor.ID,
                Date = DateTime.Now,
                Doctor = doctor,
                Patient = patient
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
            repository.Add(session);
            bool result = dbContext.SaveChanges() > 0;
            Assert.IsTrue(result);
            Transaction.Current.Rollback();
        }

        [TestMethod]
        public void FindByPIDTest()
        {
            repository.Add(session);
            IList<Session> result = repository.FindByPatientID(patient.ID);
            Assert.IsTrue(result.Count == 1 && result.Contains(session) && result[0].PID == patient.ID);
            Transaction.Current.Rollback();
        }

        [TestMethod]
        public void FindByDIDTest()
        {
            repository.Add(session);
            IList<Session> result = repository.FindByPatientID(doctor.ID);
            Assert.IsTrue(result.Count == 1 && result.Contains(session) && result[0].DID == doctor.ID);
            Transaction.Current.Rollback();
        }

        [TestMethod]
        public void RemoveTest()
        {
            repository.Add(session);
            bool result = dbContext.SaveChanges() > 0;
            repository.Remove(session);
            result = dbContext.SaveChanges() > 0;
            Assert.IsTrue(result);
            Transaction.Current.Rollback();
        }
    }
}
