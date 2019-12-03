using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Reponsitories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IErrorService
    {
        Error Add(Error error);
        void Save();
    }

    public class ErrorService : IErrorService
    {
        IErrorRepository errorRepository;
        IUnitOfWork unitOfWork;
        public ErrorService(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            this.errorRepository = errorRepository;
            this.unitOfWork = unitOfWork;
        }
        public Error Add(Error error)
        {
            return errorRepository.Add(error);
        }

        public void Save()
        {
            unitOfWork.Commit();
        }
    }
}
