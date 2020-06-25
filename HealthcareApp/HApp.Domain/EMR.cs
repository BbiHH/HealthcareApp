using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Domain
{
    public class EMR
    {
        /// <summary>
        /// EMRid
        /// </summary>
        public Guid Id
        {
            get;set;
        }

        /// <summary>
        /// 最新更新时间
        /// </summary>
        public DateTime UpdateTime
        {
            get; set;
        }

        /// <summary>
        /// 病例描述
        /// </summary>
        public string Text
        {
            get; set;
        }

        /// <summary>
        /// 加密EMR的密钥
        /// </summary>
        public string SessionKey
        {
            get; set;
        }

        /// <summary>
        /// 更新签名
        /// </summary>
        public string UpdateKey
        {
            get; set;
        }
    }
}