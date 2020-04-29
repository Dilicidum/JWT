using BLL.Interfaces;
using BLL.Models.DTO;
using BLL.Models.Resources;
using BLL.Models.Responses;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace BLL.Services
{
    public class UserService:IUserService
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;
        private IPasswordHasher passwordHasher;
        public UserService(IUnitOfWork unitOfWork,IMapper mapper,IPasswordHasher passwordHasher)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.passwordHasher = passwordHasher;
        }

        public async Task<UserResponse> CreateUser(UserResource userResource)
        {
            User userRegistered = await unitOfWork.UserRepository.FindByEmailAsync(userResource.Email);
            if (userRegistered != null)
            {
                return new UserResponse(null,false, "Email is already registered");
            }

            User user = mapper.Map<User>(userResource);
            user.Password = passwordHasher.HashPassword(user.Password);
            await unitOfWork.UserRepository.AddAsync(user);
            await unitOfWork.Commit();
            return new UserResponse(mapper.Map<UserDTO>(user), true,null);

        }

        public async Task<User> FindUserByEmailAsync(string Email)
        {
            User user = await unitOfWork.UserRepository.FindByEmailAsync(Email);
            //UserDTO userDTO = mapper.Map<UserDTO>(user);
            return user;
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            IEnumerable<User> users = await unitOfWork.UserRepository.GetAllAsync();
            IEnumerable<UserDTO> userResources = mapper.Map<IEnumerable<UserDTO>>(users);
            return userResources;
        }
    }
}
