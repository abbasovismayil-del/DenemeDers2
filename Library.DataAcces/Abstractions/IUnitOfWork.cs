using Library.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAcces.Abstractions
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Books> BooksRepo { get; }
        IRepository<Author> AuthorsRepo { get; }
        IRepository<Member> MembersRepo { get; }
        int complete();


    }
}
