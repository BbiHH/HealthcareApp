using HApp.Repository;
using HApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HApp.Service
{
    public class ServiceUse
    {
        public HappContext dbcontext
        {
            get;
            set;
        }

        public ServiceUse(HappContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }


        public ICAService CAService
        {
            get { return new CAService(dbcontext); }
        }

        public ICodeService CodeService
        {
            get { return new CodeService(dbcontext); }
        }

        public IDoctorService DoctorService
        {
            get { return new DoctorService(dbcontext); }
        }

        public IPatientService PatientService
        {
            get { return new PatientService(dbcontext); }
        }
    }
}
