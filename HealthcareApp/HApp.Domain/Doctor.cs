using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Domain
{
    public class Doctor : BaseDomain
    {
        public Doctor(string name):base()
        {
            Name = name;
        }

        /// <summary>
        /// 会话密钥集合
        /// </summary>
        public List<string> SessionKeyList
        {
            get; set;
        }

        /// <summary>
        /// EMR集合
        /// </summary>
        public List<EMR> EMRList
        {
            get;set;
        }

        /// <summary>
        /// 解开EMR
        /// </summary>
        /// <param name="SessionKey">会话密钥</param>
        public EMR UnLockEMR(string SessionKey)
        {
            //通过会话密钥找到EMR 并返回EMR
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 更新EMR
        /// </summary>
        public void UpdateEMR(EMR emr, string updatekey)
        {
            //更新后的EMR要再使用更新密钥签名，并且修改更新时间
            throw new System.NotImplementedException();
        }
    }
}