using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProtectedController
    {
        private IProtectedService protectedService;

        public ProtectedController(IProtectedService protectedService)
        {
            this.protectedService = protectedService;
        }
        [HttpGet]
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await protectedService.GetAllUsers();
        }
        [HttpGet("{id}")]
        public string GetUserById(int id)
        {
            //return await protectedService.GetUserById(id);
            return id.ToString();
        }
    }
}
