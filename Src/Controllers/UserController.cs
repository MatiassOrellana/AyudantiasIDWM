using System.Collections;
using Ayudantia1.src.Models;
using Ayudantia1.src.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Ayudantia1.src.Controllers
{
    
    public class UserController : BaseController
    {
        
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers(){

            var users = await _userRepository.GetUsers();
            return users;

        }

    }


}