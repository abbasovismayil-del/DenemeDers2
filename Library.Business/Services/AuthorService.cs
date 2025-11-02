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
    public class AuthorService : IManager<Author>
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public void Add(Author entity)
        {
            AuthorValidator bkau = new AuthorValidator();
            ValidationResult result = bkau.Validate(entity);
            StringBuilder sb = new StringBuilder();
            if (!result.IsValid)
            {
                result.Errors.ForEach(x => sb.AppendLine(x.ErrorMessage));
                throw new Exception(sb.ToString());

            }
            _unitOfWork.AuthorsRepo.Add(entity);
        }

        public void Delete(Guid id)
        {
            _unitOfWork.AuthorsRepo.Delete(id);

        }

        public List<Author> GetAll()
        {
           return _unitOfWork.AuthorsRepo.GetAll();
        }

        public Author GetById(Guid id)
        {
           return _unitOfWork.AuthorsRepo.GetById(id);
        }

        public void Update(Author entity)
        {
            if (entity == null)
            {
                throw new Exception("Guncellenecek nesne boş olamaz");
                
            }
            _unitOfWork.AuthorsRepo.Update(entity);
        }
    }
}
