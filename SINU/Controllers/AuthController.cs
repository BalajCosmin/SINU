using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SINU.DTO;
using SINU.DTO.LoginDTO;
using SINU.Repository;
using SINU.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SINU.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IUserRepository _repository;

        public AuthController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterDTO dto)
        {
            var user = new User
            {

                IDNP = dto.IDNP,
                Username = dto.Username,
                Password = dto.Password,
                Email = dto.Email
            };

            _repository.Create(user);


            return Ok("success");



            

        }


        [HttpPost("login")]
        public IActionResult Login(LoginDTO dto)
        {

            var user = _repository.GetUserByEmail(dto.Email);
            if (user == null) return BadRequest(new { message = "Invalid Credentials " });

            if (user.Password != dto.Password) return BadRequest(new { message = "Invalid Credentials " });

            return Ok(user);

        }

    }
}
