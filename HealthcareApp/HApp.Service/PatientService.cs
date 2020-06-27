using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HApp.Domain;
using HApp.Repository.Interface;
using HApp.Service.Interface;
namespace HApp.Service
{
    class PatientService : IPatientService
    {
        IEMRRepository eMRRepository;
        ICodeRepository codeRepository;
        ISessionRepository sessionRepository;

        public void CreatEMR(Patient patient)
        {
            EMR emr = new EMR();
            emr.Ppubkey = patient.PublicKey;
            emr.Ehistory = DateTime.Now.ToString() + "病例创建";
            eMRRepository.Add(emr);
        }

        public string CreatSessionKey(Patient patient)
        {
            throw new NotImplementedException();
        }

        public EMR FindEMR(string patient)
        {
            EMR emr = eMRRepository.FindByPatientPubKey(patient);
            return emr;
        }

        public string FindSessionKey(string patient)
        {
            Code code = codeRepository.FindByKey(patient);
            return code.SessionKey;
        }

        public void LockEMR(EMR emr)
        {
            throw new NotImplementedException();
        }

        public IList<Session> ShowSession(Patient patient)
        {
            IList<Session> sessions = sessionRepository.FindByPatientID(patient.ID);
            return sessions;
        }
    }
}
