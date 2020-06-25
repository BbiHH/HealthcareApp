using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Repository.Interface
{
    public interface IRepository<T>
    {
        void Add(T entity);
        /// <summary>
        /// 由ID找到
        /// </summary>
        T FindById(Guid Id);
        /// <summary>
        /// 修改
        /// </summary>
        void Modify(T entity);
        /// <summary>
        /// 删除
        /// </summary>
        void Remove(T entity);
    }
}