using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HApp.Domain;
using HApp.Repository.Interface;
using HApp.Repository;

namespace HApp.Domaindo
{
    class Program
    {
        static void Main(string[] args)
        {
            HappContext dbContext = new HappContext();
            IEMRRepository eMRRepository = new EMRRepository(dbContext);
            ISessionRepository sessionRepository = new SessionRepository(dbContext);
            EMR eMR = new EMR() { ID = Guid.NewGuid(),Ppubkey= "P@u0d?#1N3z" };
            eMRRepository.Add(eMR);
            dbContext.SaveChanges();
        }
    }
}
