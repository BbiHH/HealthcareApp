using HApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Service.Interface
{
    public interface IDoctorService
    {
        /// <param name="emr">病例</param>
        /// <param name="text">添加信息</param>
        void ModifyEMR(EMR emr, string text,Doctor dr);
        EMR unLockEMR(string publickey,string sessionkey);
        IList<Querise> ShowEMR(Doctor dr);
        IList<Session> ShowSession(Doctor doctor);
    }
}