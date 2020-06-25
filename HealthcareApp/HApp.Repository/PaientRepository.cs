using HApp.Domain;
using HApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Repository
{
    public class PatientRepository : BaseRepository<Patient> , IPaientRepository
    {
        public PatientRepository(HappContext context):base(context)
        {
        }
    }
}