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
    public class BookService : IManager<Books>
    {
        private readonly IUnitOfWork _unitOfWork;
        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
        }
        public void Add(Books entity)
        {
            BooksValidator bkval=new BooksValidator();
            ValidationResult result=bkval.Validate(entity);
            StringBuilder sb=new StringBuilder();
            if (!result.IsValid)
            {
                result.Errors.ForEach(x=> sb.AppendLine(x.ErrorMessage));
                throw new Exception(sb.ToString());
                
            }
            _unitOfWork.BooksRepo.Add(entity);
        }

        public void Delete(Guid id)
        {
            _unitOfWork.BooksRepo.Delete(id);
        }

        public List<Books> GetAll()
        {
           return _unitOfWork.BooksRepo.GetAll();
        }

        public Books GetById(Guid id)
        {
            return _unitOfWork.BooksRepo.GetById(id);
        }

        public void Update(Books entity)
        {
            if (entity==null)
            {
                throw new Exception("Guncellenecek nesne boş olamaz");
                
            }
            _unitOfWork.BooksRepo.Update(entity);
        }
    }
}
