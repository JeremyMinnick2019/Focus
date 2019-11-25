using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FocusBackend.Data;
using FocusBackend.Models;
using FocusBackend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FocusBackend.Controllers
{
    [Route("api/activities")]
    [ApiController]
    public class ActivityController : ControllerBase
    {

        private IRepository<Activity> activityRepo;

        public ActivityController(IRepository<Activity> activityRepo)
        {
            this.activityRepo = activityRepo;
        }

        // GET api/Activitys
        [HttpGet]
        public IEnumerable<Activity> Get()
        {
            return activityRepo.GetAll();
            //return new List<Activity>();
        }

        // GET api/activities/5
        [HttpGet("{id}")]
        public Activity Get(int id)
        {
            return activityRepo.GetById(id);
        }

        //Get api/activities/done
        [HttpGet("done")]
        public IEnumerable<Activity> GetDone()
        {
            return activityRepo.GetByDone();
        }

        // POST api/Activitys
        [HttpPost]
        public IEnumerable<Activity> Post([FromBody] Activity Activity)
        {
            activityRepo.Create(Activity);
            return activityRepo.GetAll();
        }

        // PUT api/Activitys/5
        [HttpPut("{id}")]
        public IEnumerable<Activity> Put([FromBody] Activity Activity)
        {
            activityRepo.Update(Activity);
            return activityRepo.GetAll();
        }

        // DELETE api/Activitys/5
        [HttpDelete("{id}")]
        public IEnumerable<Activity> Delete(int id)
        {
            var Activity = activityRepo.GetById(id);
            activityRepo.Delete(Activity);
            return activityRepo.GetAll();
        }
    }
}