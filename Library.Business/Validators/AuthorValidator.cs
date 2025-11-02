using FluentValidation;
using Library.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Validators
{
    public class AuthorValidator:AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName)
                .NotEmpty()
                .WithMessage("Yazar Adı Boş Geçilemez");
        }
    }
}
