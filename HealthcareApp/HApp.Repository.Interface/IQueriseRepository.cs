using HApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HApp.Repository.Interface
{
    public interface IQueriseRepository
    {
        void Add(Querise entity);
        /// <summary>
        /// 由会话密钥找到查询记录
        /// </summary>
        IList<Querise> FindByDoctorID(Guid ID);
        /// <summary>
        /// 修改
        /// </summary>
        void Modify(Querise entity);
        /// <summary>
        /// 删除
        /// </summary>
        void Remove(Querise entity);
    }
}
