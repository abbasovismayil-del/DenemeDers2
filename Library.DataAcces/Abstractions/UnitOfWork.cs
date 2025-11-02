using Library.DataAcces.Context;
using Library.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAcces.Abstractions
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<Books> BooksRepo { get; }
        public IRepository<Author> AuthorsRepo { get; }
        public IRepository<Member> MembersRepo { get; }

        private readonly ApplicationDBContext _dbContext;
        public UnitOfWork(ApplicationDBContext context)
        {
            _dbContext = context;
            BooksRepo = new GenericRepository<Books>(_dbContext);
            AuthorsRepo = new GenericRepository<Author>(_dbContext);
            MembersRepo = new GenericRepository<Member>(_dbContext);


        }
        public int complete()=>_dbContext.SaveChanges();

        public void Dispose()=>_dbContext.Dispose();
    }
}
