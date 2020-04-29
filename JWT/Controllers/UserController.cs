using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLL.Interfaces;
using Microsoft.AspNetCore.Server.IIS.Core;
using BLL.Models.Resources;
using BLL.Models.DTO;

namespace API.Controllers
{
    [Route("api/Registration")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Registrate(UserResource userResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var Response =(await userService.CreateUser(userResource));

            if (!Response.Sucess)
            {
                return BadRequest(Response.Message);
            }

            var result = await userService.FindUserByEmailAsync(userResource.Email);

            return NoContent();
        }

        [HttpGet]
        public async Task<IEnumerable<UserDTO>> GetAllUsers()
        {
            return await userService.GetAllUsersAsync();
        }

    }
}
