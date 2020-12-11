using AutoMapper;
using Artisan.Entity;
using Artisan.Models;
using Artisan.Services;
using Artisan.Setting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artisan.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
   
    public class UserController: ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;

        public UserController(IUserService userService , IMapper mapper)
        {
            _userService = userService;
           _mapper = mapper;

        }

    [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {
            var user = _userService.Authenticate(model.Email, model.Password);

            if (user == null)
                return BadRequest(new { message = "Email or password is incorrect" });

            return Ok(user);
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult Getall()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
        [AllowAnonymous]
        [HttpGet("getart")]
        public IActionResult Getart()
        {
            var users = _userService.Getart();
            return Ok(users);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]RegisterModel model)
        {
            // map model to entity
            var user = _mapper.Map<Users>(model);


            try
            {
                // create user
                _userService.Create(user, model.password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }


        [AllowAnonymous]
        [HttpPost("registerArtisan")]
        public IActionResult RegisterArtisan([FromBody]RegisterModel model)
        {

            var user = _mapper.Map<Users>(model);



            try
            {
                // create user
                _userService.creatArtisan(user, model.password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }
        [AllowAnonymous]
        [HttpGet("userByid/{id}")]
        public async Task<IActionResult> GetbyId(int id)
        {
            var user = await _userService.GetbyId(id);
            return Ok(user);
        }




    }
}
