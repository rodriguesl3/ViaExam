using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViaExam.Auth.Application.Services;
using ViaExam.Auth.Domain.Entities;

namespace ViaExam.Auth.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthenticationController : Controller
    {

        [HttpGet]
        public IActionResult GetUser(Authentication authentication, [FromServices] IAuthenticationServices _authService)
        {
            try
            {

                var user = _authService.GetUser(authentication);

                return Ok(user);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult SetUser(Authentication authentication, [FromServices] IAuthenticationServices _authServices)
        {
            var user = _authServices.SetUser(authentication);
            return Ok(user);
        }

    }
}