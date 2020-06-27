using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HApp.Domain;
using HApp.Repository;
using HApp.Repository.Interface;
using HApp.Service.Interface;
namespace HApp.Service
{
    public class PatientService :BaseService, IPatientService
    {
        public PatientService(HappContext context) : base(context)
        {

        }

        public EMR CreatEMR(Patient patient)
        {
            EMR emr = new EMR();
            emr.Ppubkey = patient.PublicKey;
            emr.Ehistory = "姓名:" + patient.Name;
            emr.Ehistory = emr.Ehistory + "\r\n"+DateTime.Now.ToString() + "病例创建";
            emrRepository.Add(emr);
            return emr;
        }

        public string CreatSessionKey(Patient patient)
        {
            throw new NotImplementedException();
        }

        public EMR FindEMR(string patient)
        {
            EMR emr = emrRepository.FindByPatientPubKey(patient);
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
