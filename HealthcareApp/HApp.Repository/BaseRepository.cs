using HApp.Domain;
using HApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace HApp.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseClass, new()
    {
        protected readonly HappContext _context;  //映射过来的数据
        protected DbSet<T> _DbSet
        {
            get { return _context.Set<T>(); }
        }

        public BaseRepository(HappContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("context");
            }

            _context = context;
        }

        public void Add(T entity)
        {
            _DbSet.Add(entity);
        }

        public T FindById(Guid Id)
        {
            return _DbSet.Find(Id);
        }

        public void Modify(T entity)
        {
            _DbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(T entity)
        {
            _DbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Deleted;
        }
    }
}