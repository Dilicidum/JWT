using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
namespace BLL.Interfaces
{
    public interface IProtectedService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
    }
}
