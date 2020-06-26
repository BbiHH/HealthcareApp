using HApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HApp.Repository.Interface
{
    public interface ICodeRepository
    {
        void Add(Code entity);
        /// <summary>
        /// 由ID找到
        /// </summary>
        Code FindByKey(string key);
        /// <summary>
        /// 修改
        /// </summary>
        void Modify(Code entity);
        /// <summary>
        /// 删除
        /// </summary>
        void Remove(Code entity);
    }
}
