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
        private SessionRepository sessionrepository;
        private DoctorRepository doctorRepository;
        private PatientRepository patientRepository;
        private Session session;
        private Doctor doctor;
        private Patient patient;

        [TestInitialize]
        public void TestInitialize()
        {
            transactionScope = new TransactionScope();
            dbContext = new HappContext();
            sessionrepository = new SessionRepository(dbContext);
            doctorRepository = new DoctorRepository(dbContext);
            patientRepository = new PatientRepository(dbContext);
            doctor = new Doctor();
            patient = new Patient();
            session = new Session() {
                PID = patient.ID,
                DID = doctor.ID,
                Date = DateTime.Now,
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
            doctorRepository.Add(doctor);
            patientRepository.Add(patient);
            sessionrepository.Add(session);
            bool result = dbContext.SaveChanges() > 2;
            Assert.IsTrue(result);
            Transaction.Current.Rollback();
        }

        [TestMethod]
        public void FindByPIDTest()
        {
            sessionrepository.Add(session);
            IList<Session> result = sessionrepository.FindByPatientID(patient.ID);
            Assert.IsTrue(result.Count == 1 && result.Contains(session) && result[0].PID == patient.ID);
            Transaction.Current.Rollback();
        }

        [TestMethod]
        public void FindByDIDTest()
        {
            sessionrepository.Add(session);
            IList<Session> result = sessionrepository.FindByPatientID(doctor.ID);
            Assert.IsTrue(result.Count == 1 && result.Contains(session) && result[0].DID == doctor.ID);
            Transaction.Current.Rollback();
        }

        [TestMethod]
        public void RemoveTest()
        {
            sessionrepository.Add(session);
            bool result = dbContext.SaveChanges() > 0;
            sessionrepository.Remove(session);
            result = dbContext.SaveChanges() > 0;
            Assert.IsTrue(result);
            Transaction.Current.Rollback();
        }
    }
}
