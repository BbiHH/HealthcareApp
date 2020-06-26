using HApp.Domain;

namespace HApp.Service.Interface
{
    public interface ICodeService
    {
        bool LockSession(string pubkey, string prikey);
        bool LockEMR(EMR emr, string session);
    }
}