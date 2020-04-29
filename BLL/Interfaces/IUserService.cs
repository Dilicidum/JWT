using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models.Responses;
using BLL.Models.Resources;
using BLL.Models.DTO;
using DAL.Entities;
namespace BLL.Interfaces
{
    public interface IUserService
    {
        Task<UserResponse> CreateUser(UserResource user);
        Task<User> FindUserByEmailAsync(string Email);
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
    }
}