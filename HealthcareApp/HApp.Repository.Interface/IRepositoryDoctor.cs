using HApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Repository.Interface
{
    public interface IDoctorRepository : IRepository<Doctor>
    {
        /// <summary>
        /// 返回获取到的所有EMR
        /// </summary>
        List<EMR> FindAllEMR();
    }
}