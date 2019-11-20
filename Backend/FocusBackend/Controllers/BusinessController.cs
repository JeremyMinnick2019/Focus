using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FocusBackend.Models;
using FocusBackend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FocusBackend.Controllers
{
    [Route("api/businesses")]
    [ApiController]
    public class BusinessController : ControllerBase
    {

        private IRepository<Business> businessRepo;

        public BusinessController(IRepository<Business> businessRepo)
        {
            this.businessRepo = businessRepo;
        }

        // GET api/Business
        [HttpGet]
        public IEnumerable<Business> Get()
        {
            return businessRepo.GetAll();
            //return new List<Business>();
        }

        // GET api/Business/5
        [HttpGet("{id}")]
        public Business Get(int id)
        {
            return businessRepo.GetById(id);
        }

        // POST api/Business
        [HttpPost]
        public IEnumerable<Business> Post([FromBody] Business Business)
        {
            businessRepo.Create(Business);
            return businessRepo.GetAll();
        }

        // PUT api/Business/5
        [HttpPut("{id}")]
        public IEnumerable<Business> Put([FromBody] Business Business)
        {
            businessRepo.Update(Business);
            return businessRepo.GetAll();
        }

        // DELETE api/Business/5
        [HttpDelete("{id}")]
        public IEnumerable<Business> Delete(int id)
        {
            var Business = businessRepo.GetById(id);
            businessRepo.Delete(Business);
            return businessRepo.GetAll();
        }
    }
}