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
    public class CodeRepository :ICodeRepository
    {
        protected readonly HappContext _context;  //映射过来的数据
        protected DbSet<Code> _DbSet
        {
            get { return _context.Set<Code>(); }
        }

        public CodeRepository(HappContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("context");
            }

            _context = context;
        }

        public void Add(Code entity)
        {
            _DbSet.Add(entity);
        }

        public Code FindByKey(string Key)
        {
            return _DbSet.Find(Key);
        }

        public void Modify(Code entity)
        {
            _DbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(Code entity)
        {
            _DbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Deleted;
        }
    }
}
