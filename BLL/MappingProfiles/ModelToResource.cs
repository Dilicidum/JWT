using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models.DTO;
using BLL.Models.Resources;
using AutoMapper;
using DAL.Entities;

namespace BLL.MappingProfiles
{
    public class ModelToResource:Profile
    {
        public ModelToResource()
        {
            CreateMap<UserDTO, UserResource>();
            CreateMap<User, UserResource>();
            CreateMap<User, UserDTO>();
        }
    }
}
