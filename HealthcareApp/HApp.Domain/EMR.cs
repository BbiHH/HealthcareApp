using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Domain
{
    public class EMR : BaseClass
    {

        /// <summary>
        /// 病例描述
        /// </summary>
        public string Ehistory
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

        public virtual ICollection<Patient> Patient { get; set; }
    }
}