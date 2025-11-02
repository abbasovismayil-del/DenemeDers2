using Library.Entity.Abstractiıons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAcces.Abstractions
{
    public interface IRepository<T> where T:BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid ID);
        T GetById(Guid ID);
        List<T> GetAll();
    }
}
