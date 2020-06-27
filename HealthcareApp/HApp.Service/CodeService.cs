using HApp.Domain;
using HApp.Repository;
using HApp.Repository.Interface;
using HApp.Service.Interface;

namespace HApp.Service
{
    public class CodeService : BaseService, ICodeService
    {
        public CodeService(HappContext context):base(context)
        {
        }

        public bool LockEMR(EMR emr, string session)
        {
            string publicKey =  emr.Ppubkey;
            string sessionKey = session;
            Code code =  codeRepository.FindByKey(sessionKey);
            if(code.Cpubkey.Equals(publicKey))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LockSession(string pubkey, string prikey)
        {
            Code code = codeRepository.FindByKey(pubkey);
            if (code.Cprikey.Equals(prikey))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
