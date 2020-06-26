using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HApp.Domain;
using HApp.Service.Interface;
namespace HApp.Service
{
    class PatientService : IPatientService
    {
        public void CreatEMR(Patient patient)
        {
            throw new NotImplementedException();
        }

        public string CreatSessionKey(Patient patient)
        {
            throw new NotImplementedException();
        }

        public EMR FindEMR(string patient)
        {
            throw new NotImplementedException();
        }

        public string FindSessionKey(string patient)
        {
            throw new NotImplementedException();
        }

        public void LockEMR(EMR emr)
        {
            throw new NotImplementedException();
        }

        public IList<Session> ShowSession(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
