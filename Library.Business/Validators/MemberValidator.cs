using FluentValidation;
using Library.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Validators
{
    public class MemberValidator:AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(x => x.NameSurname)
                .NotEmpty()
                .WithMessage("Uye Adı ve soyadı Boş Geçilemez");
        }
    }
}
