using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HApp.Domain;
using HApp.Repository.Interface;
namespace HApp.Repository
{
    public class QueriseRepository : IQueriseRepository
    {
        protected readonly HappContext _context;  //映射过来的数据
        protected DbSet<Querise> _DbSet
        {
            get { return _context.Set<Querise>(); }
        }

        public QueriseRepository(HappContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("context");
            }

            _context = context;
        }

        public void Add(Querise entity)
        {
            _DbSet.Add(entity);
        }

        public void Modify(Querise entity)
        {
            _DbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(Querise entity)
        {
            _DbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public IList<Querise> FindByDoctorID(Guid ID)
        {
            return null;
        }
    }
}
