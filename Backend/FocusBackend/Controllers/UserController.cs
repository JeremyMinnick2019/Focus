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

        private IRepository<User> userRepo;

        public UserController(IRepository<User> UserRepo)
        {
            this.userRepo = userRepo;
        }

        // GET api/Users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return userRepo.GetAll();
            //return new List<User>();
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return userRepo.GetById(id);
        }

        // POST api/Users
        [HttpPost]
        public IEnumerable<User> Post([FromBody] User User)
        {
            userRepo.Create(User);
            return userRepo.GetAll();
        }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public IEnumerable<User> Put([FromBody] User User)
        {
            userRepo.Update(User);
            return userRepo.GetAll();
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public IEnumerable<User> Delete(int id)
        {
            var User = userRepo.GetById(id);
            userRepo.Delete(User);
            return userRepo.GetAll();
        }
    }
}
