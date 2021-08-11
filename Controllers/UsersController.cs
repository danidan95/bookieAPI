using bookieAPI.DTOs;
using bookieAPI.Models;
using bookieAPI.Repositories.UserRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookieAPI.Controllers
{
    
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        [Route("/Users/Create")]
        public IActionResult Create([FromBody] User user)
        {
            return Ok(_userRepository.Create(user));
        }

        [HttpPost]
        [Route("/Users/Login")]
        public IActionResult Login([FromForm] LoginDTO loginDTO)
        {
            return Ok(_userRepository.Login(loginDTO));
        }
    }
}
