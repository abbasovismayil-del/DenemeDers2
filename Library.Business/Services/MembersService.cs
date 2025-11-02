using FluentValidation.Results;
using Library.Business.ABstraction;
using Library.Business.Validators;
using Library.DataAcces.Abstractions;
using Library.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Services
{
    public class MembersService : IManager<Member>
    {
        private readonly IUnitOfWork _unitOfWork;
        public MembersService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        public void Add(Member entity)
        {
            MemberValidator bkm = new MemberValidator();
            ValidationResult result = bkm.Validate(entity);
            StringBuilder sb = new StringBuilder();
            if (!result.IsValid)
            {
                result.Errors.ForEach(x => sb.AppendLine(x.ErrorMessage));
                throw new Exception(sb.ToString());

            }
            _unitOfWork.MembersRepo.Add(entity);
        }


        public void Delete(Guid id)
        {
            _unitOfWork.MembersRepo.Delete(id);
        }

        public List<Member> GetAll()
        {
            return _unitOfWork.MembersRepo.GetAll();
        }

        public Member GetById(Guid id)
        {
            return _unitOfWork.MembersRepo.GetById(id);
        }

        public void Update(Member entity)
        {
            if (entity == null)
            {
                throw new Exception("Guncellenecek nesne boş olamaz");

            }
            _unitOfWork.MembersRepo.Update(entity);
        }
    }
}
