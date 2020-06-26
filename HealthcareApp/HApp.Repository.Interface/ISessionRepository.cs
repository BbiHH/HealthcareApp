using HApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HApp.Repository.Interface
{
    public interface ISessionRepository
    {
        void Add(Session entity);
        /// <summary>
        /// 由患者ID找到会诊纪录
        /// </summary>
        IList<Session> FindByPatientID(Guid ID);
        /// <summary>
        /// 由患者ID找到会诊纪录
        /// </summary>
        IList<Session> FindByDoctorID(Guid ID);
        /// <summary>
        /// 修改
        /// </summary>
        void Modify(Session entity);
        /// <summary>
        /// 删除
        /// </summary>
        void Remove(Session entity);
    }
}
