using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Domain
{
    public class Patient : BaseDomain
    {
        public Patient(string name):base()
        {
            Name = name;
        }

        public EMR EMR
        {
            get; set;
        }

        /// <summary>
        /// 会话密钥
        /// </summary>
        public string SessionKey
        {
            get; set;
        }

        /// <summary>
        /// 生成密钥
        /// </summary>
        /// <param name="PublicKey">公钥</param>
        /// <param name="privateKey">密钥</param>
        public bool CreatSessionKey(string PublicKey, string privateKey)
        {
            //通过公钥与私钥创建会话密钥 加入数据库
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 解锁EMR
        /// </summary>
        /// <param name="EMRid">EMRid</param>
        /// <param name="SessionKey">会话密钥</param>
        public EMR FindEMR(Guid EMRid, string SessionKey)
        {
            //通过EMRid 、 会话密钥找到解开EMR
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 加密EMR
        /// </summary>
        /// <param name="EMRid">EMRid</param>
        /// <param name="SessionKey">加密的密钥</param>
        public bool LockEMR(EMR emr, string SessionKey)
        {
            //将EMR加入数据库并且记录其加密的会话密钥
            throw new System.NotImplementedException();
        }
    }
}