using Library.Entity.Abstractiıons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.Models
{
    public class Books:BaseEntity
    {
        public string? BookName { get; set; }
        public Guid AuthorID { get; set; }
        public Author? Author { get; set; }
        public string? Publisher { get; set; }

    }
}
