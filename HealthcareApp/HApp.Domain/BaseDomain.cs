using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Domain
{
    public abstract class BaseDomain
    {
        /// <summary>
        /// 私钥
        /// </summary>
        private string privateKey;

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// 公钥
        /// </summary>
        public string PublicKey
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// ID
        /// </summary>
        public Guid Id
        {
            get; set;
        }

        public void CreatKey()
        {
            //创建公钥与密钥,加入数据库
            throw new System.NotImplementedException();
        }
    }
}