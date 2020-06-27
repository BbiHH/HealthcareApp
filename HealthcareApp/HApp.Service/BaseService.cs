using HApp.Domain;
using HApp.Repository;
using HApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HApp.Service
{
    public abstract class BaseService
    {
        public IEMRRepository emrRepository { get; set; }
        public ICodeRepository codeRepository { get; set; }
        public IQueriseRepository queriseRepository { get; set; }
        public ISessionRepository sessionRepository { get; set; }
        public IDoctorRepository doctorRepository { get; set; }
        public IPaientRepository patientRepository { get; set; }

        public BaseService(HappContext dbContext)
        {
            emrRepository = new EMRRepository(dbContext);
            codeRepository = new CodeRepository(dbContext);
            queriseRepository = new QueriseRepository(dbContext);
            sessionRepository = new SessionRepository(dbContext);
            doctorRepository = new DoctorRepository(dbContext);
            patientRepository = new PatientRepository(dbContext); 
        }
    }
}
