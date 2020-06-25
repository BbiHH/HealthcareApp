using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Domain
{
    public abstract class BaseDomain : BaseClass
    {
        /// <summary>
        /// 私钥
        /// </summary>
        private string privateKey;

        public BaseDomain()
        {
            CreatKey();
        }

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
            get;set;
        }

        public void CreatKey()
        {
            //创建公钥与密钥,加入数据库
            PublicKey = "P@" + GetRandomString(9, true, true, true, true, "");
            privateKey = "p@" + GetRandomString(8, true, true, true, true, "");
        }

        //生成随机字符串
        public string GetRandomString(int length, bool useNum, bool useLow, bool useUpp, bool useSpe, string custom)
        {
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            Random r = new Random(BitConverter.ToInt32(b, 0));
            string s = null, str = custom;
            if (useNum == true) { str += "0123456789"; }
            if (useLow == true) { str += "abcdefghijklmnopqrstuvwxyz"; }
            if (useUpp == true) { str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            if (useSpe == true) { str += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~"; }
            for (int i = 0; i < length; i++)
            {
                s += str.Substring(r.Next(0, str.Length - 1), 1);
            }
            return s;
        }
    }
}