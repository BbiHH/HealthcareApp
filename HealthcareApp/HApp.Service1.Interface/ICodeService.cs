using HApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Service.Interface
{
    public interface ICodeService
    {
        bool LockSession(string pubkey, string prikey);
        bool LockEMR(EMR emr, string session);
    }
}