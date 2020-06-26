using HApp.Domain;
using HApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HApp.Repository
{
    public class SessionRepository: ISessionRepository
    {
        protected readonly HappContext _context;  //映射过来的数据
        protected DbSet<Session> _DbSet
        {
            get { return _context.Set<Session>(); }
        }

        public SessionRepository(HappContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("context");
            }

            _context = context;
        }

        public void Add(Session entity)
        {
            _DbSet.Add(entity);
        }

        public void Modify(Session entity)
        {
            _DbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(Session entity)
        {
            _DbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public IList<Session> FindByPatientID(Guid ID)
        {
            var result = _DbSet.Where(t => t.DID == ID).ToList();
            return result;
        }

        public IList<Session> FindByDoctorID(Guid ID)
        {
            var result = _DbSet.Where(t => t.DID == ID).ToList();
            return result;
        }
    }
}
