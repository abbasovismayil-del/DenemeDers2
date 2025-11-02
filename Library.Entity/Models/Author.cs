using Library.Entity.Abstractiıons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.Models
{
    public class Author:BaseEntity
    {
        public string? AuthorName { get; set; }
        public string? Nationality { get; set; }
        public DateTime DateofBirth { get; set; }
        public string? Description { get; set; }
        public List<Books>? Books{ get; set; }
    }
}
