using FocusBackend.Models;
using FocusBackend.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusBackend.Controllers
{
    [Route("api/games")]
    [ApiController]
    public class GameController : ControllerBase
    {

        private IRepository<Game> gameRepo;

        public GameController(IRepository<Game> gameRepo)
        {
            this.gameRepo = gameRepo;
        }

        // GET api/Categorys
        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return gameRepo.GetAll();
            //return new List<Category>();
        }

        // GET api/Categorys/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return gameRepo.GetById(id);
        }

        // POST api/Categorys
        [HttpPost]
        public IEnumerable<Game> Post([FromBody] Game Game)
        {
            gameRepo.Create(Game);
            return gameRepo.GetAll();
        }

        // PUT api/Categorys/5
        [HttpPut("{id}")]
        public IEnumerable<Game> Put([FromBody] Game Game)
        {
            gameRepo.Update(Game);
            return gameRepo.GetAll();
        }

        // DELETE api/Categorys/5
        [HttpDelete("{id}")]
        public IEnumerable<Game> Delete(int id)
        {
            var Game = gameRepo.GetById(id);
            gameRepo.Delete(Game);
            return gameRepo.GetAll();
        }
    }
}
