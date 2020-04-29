using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLL.Models.Resources;
using BLL.Interfaces;
using BLL.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController:ControllerBase
    {
        private ILoginService loginService;

        public LoginController(ILoginService loginService)
        {
            this.loginService = loginService;
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserResource userResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await loginService.CreateAccessTokenAsync(userResource.Email, userResource.Password);
            if (!response.Sucess)
            {
                return BadRequest(response.Message);
            }

            

            return Ok(response.Token);
        }

        
    }
}
