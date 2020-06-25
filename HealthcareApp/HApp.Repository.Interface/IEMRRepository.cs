using HApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Repository.Interface
{
    public interface IEMRRepository : IRepository<EMR>
    {
        /// <summary>
        /// 通过会话密钥找到EMR
        /// </summary>
        EMR FindBySessionKey();
    }
}