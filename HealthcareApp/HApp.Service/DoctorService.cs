using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using HApp.Domain;
using HApp.Repository;
using HApp.Repository.Interface;
using HApp.Service.Interface;
namespace HApp.Service
{
    public class DoctorService :BaseService, IDoctorService
    {
        HappContext context;
        public DoctorService(HappContext context):base(context)
        {
            this.context = context;
        }

        public EMR FindEMRbyID(Guid guid)
        {
            EMR emr = emrRepository.FindById(guid);
            return emr;
        }

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

        public EMR unLockEMR(string publickey, string sessionkey , Doctor doctor)
        {
            EMR emr = emrRepository.FindByPatientPubKey(publickey);
            CodeService codeService = new CodeService(context);
            
            bool l =  codeService.LockEMR(emr, sessionkey);

            if (l)
            {
                queriseRepository.Add(new Querise() { EID = emr.ID,DID=doctor.ID,SessionKey=sessionkey});
                return emr;
            }
            else
            {
                return null;
            }
        }
    }
}
