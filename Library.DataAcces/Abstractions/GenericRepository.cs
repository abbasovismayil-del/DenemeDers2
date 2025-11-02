using Library.DataAcces.Context;
using Library.Entity.Abstractiıons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAcces.Abstractions
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDBContext _dbcontext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(ApplicationDBContext context)
        {
            _dbcontext = context;
            _dbSet = _dbcontext.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(Guid ID)
        {
            _dbSet.Remove(GetById(ID));
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(Guid ID)
        {
            var data = _dbSet.Find(ID);
            if (data == null) {
                throw new Exception("Entity not found");
            }
            return data;
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
