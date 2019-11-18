using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FocusBackend.Models;
using FocusBackend.Repositories;

namespace FocusBackend.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private IRepository<User> UserRepo;

        public UserController(IRepository<User> UserRepo)
        {
            this.UserRepo = UserRepo;
        }

        // GET api/Users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return UserRepo.GetAll();
            //return new List<User>();
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return UserRepo.GetById(id);
        }

        // POST api/Users
        [HttpPost]
        public IEnumerable<User> Post([FromBody] User User)
        {
            UserRepo.Create(User);
            return UserRepo.GetAll();
        }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public IEnumerable<User> Put([FromBody] User User)
        {
            UserRepo.Update(User);
            return UserRepo.GetAll();
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public IEnumerable<User> Delete(int id)
        {
            var User = UserRepo.GetById(id);
            UserRepo.Delete(User);
            return UserRepo.GetAll();
        }
    }
}
