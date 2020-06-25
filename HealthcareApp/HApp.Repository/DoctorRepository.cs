using HApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HApp.Domain;

namespace HApp.Repository
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(HappContext context) : base(context)
        {
        }

        public List<EMR> FindAllEMR()
        {
            throw new NotImplementedException();
        }
    }
}