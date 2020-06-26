using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using HApp.Domain;
using HApp.Repository.Interface;
using HApp.Service.Interface;
namespace HApp.Service
{
    class DoctorService : IDoctorService
    {
        IEMRRepository emrRepository;
        ICodeRepository codeRepository;
        IQueriseRepository queriseRepository;
        ISessionRepository sessionRepository;
        public void ModifyEMR(EMR emr, string text, Doctor dr)
        {
            emr.Ehistory = emr.Ehistory + "\r\n\r\n" +"时间：" +DateTime.Now.ToString() +"具体"+text;
            emr.Ehistory = emr.Ehistory + "\r\n\t\t" + "主任医师:" + dr.Name + "\t签名:" + dr.PublicKey;
            emrRepository.Modify(emr);
        }

        public IList<Querise> ShowEMR(Doctor dr)
        {
            IList<Querise> s = queriseRepository.FindByDoctorID(dr.ID);
            return s;
        }

        public IList<Session> ShowSession(Doctor doctor)
        {
            IList<Session> s = sessionRepository.FindByDoctorID(doctor.ID);
            return s;
        }

        public EMR unLockEMR(string publickey, string sessionkey)
        {
            EMR emr = emrRepository.FindByPatientPubKey(publickey);
            CodeService codeService = new CodeService(codeRepository);
            
            bool l =  codeService.LockEMR(emr, sessionkey);

            if (l)
            {
                return emr;
            }
            else
            {
                return null;
            }
        }
    }
}
