using HApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Service.Interface
{
    public interface IPatientService
    {
        /// <summary>
        /// 获取EMR
        /// </summary>
        EMR FindEMR(string patient);
        /// <summary>
        /// EMR加密
        /// </summary>
        void LockEMR(EMR emr);
        string CreatSessionKey(Patient patient);
        string FindSessionKey(string patient);
        /// <summary>
        /// 生成EMR
        /// </summary>
        void CreatEMR(Patient patient);
        IList<Session> ShowSession(Patient patient);
    }
}