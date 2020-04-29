using BLL.Interfaces;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
namespace BLL.Services
{
    public class ProtectedService:IProtectedService
    {
        private IUnitOfWork unitOfWork;
        public ProtectedService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<User> GetUserById(int id)
        {
            return await unitOfWork.UserRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await unitOfWork.UserRepository.GetAllAsync();
        }
    }
}