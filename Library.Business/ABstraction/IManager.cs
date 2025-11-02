using Library.Entity.Abstractiıons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.ABstraction
{
    public interface IManager<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
        T GetById(Guid id);
        List<T> GetAll();
    }
}
