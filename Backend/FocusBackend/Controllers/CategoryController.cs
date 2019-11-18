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
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private IRepository<Category> categoryRepo;

        public CategoryController(IRepository<Category> categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        // GET api/Categorys
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return categoryRepo.GetAll();
            //return new List<Category>();
        }

        // GET api/Categorys/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return categoryRepo.GetById(id);
        }

        // POST api/Categorys
        [HttpPost]
        public IEnumerable<Category> Post([FromBody] Category Category)
        {
            categoryRepo.Create(Category);
            return categoryRepo.GetAll();
        }

        // PUT api/Categorys/5
        [HttpPut("{id}")]
        public IEnumerable<Category> Put([FromBody] Category Category)
        {
            categoryRepo.Update(Category);
            return categoryRepo.GetAll();
        }

        // DELETE api/Categorys/5
        [HttpDelete("{id}")]
        public IEnumerable<Category> Delete(int id)
        {
            var Category = categoryRepo.GetById(id);
            categoryRepo.Delete(Category);
            return categoryRepo.GetAll();
        }
    }
}