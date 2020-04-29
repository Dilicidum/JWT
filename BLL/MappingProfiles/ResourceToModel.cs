using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Models.Resources;
using DAL.Entities;
using BLL.Models.DTO;
namespace BLL.MappingProfiles
{
    public class ResourceToModel:Profile
    {
        public ResourceToModel()
        {
            CreateMap<UserResource, UserDTO>();
            CreateMap<UserResource, User>();
            CreateMap<UserDTO, User>();
        }
    }
}
