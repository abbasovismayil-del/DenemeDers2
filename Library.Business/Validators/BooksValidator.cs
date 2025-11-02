using FluentValidation;
using Library.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Validators
{
    public class BooksValidator:AbstractValidator<Books>
    {
        public BooksValidator()
        {
            RuleFor(x => x.BookName)
                .NotEmpty()
                .WithMessage("Kitap Adı Boş Geçilemez");
        }
    }
}
