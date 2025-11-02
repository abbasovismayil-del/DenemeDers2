using Library.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAcces.Context
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=UGURSAHIN\SQLEXPRESS;Initial Catalog=YMYP9-Library;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
