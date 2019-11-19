using FocusBackend.Controllers;
using FocusBackend.Models;
using FocusBackend.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace FocusBackend.Tests
{
    public class CategoryControllerTests
    {
        private CategoryController underTest;
        IRepository<Category> categoryRepo;

        public CategoryControllerTests()
        {
            categoryRepo = Substitute.For<IRepository<Category>>();
            underTest = new CategoryController(categoryRepo);
        }

        [Fact]
        public void Get_Returns_List_of_Categorys()
        {
            var expectedCategorys = new List<Category>()
            {
                new Category(1, "Name", "Description", 1),
                new Category(2, "Name", "Description", 1)
        };
            categoryRepo.GetAll().Returns(expectedCategorys);

            var result = underTest.Get();

            Assert.Equal(expectedCategorys, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_Category()
        {
            var newCategory = new Category(1, "Name", "Description", 1);
            var CategoryList = new List<Category>();

            categoryRepo.When(t => t.Create(newCategory))
                .Do(t => CategoryList.Add(newCategory));

            categoryRepo.GetAll().Returns(CategoryList);

            var result = underTest.Post(newCategory);

            Assert.Contains(newCategory, result);
        }

        [Fact]
        public void Delete_Removes_Category()
        {
            var CategoryId = 1;
            var deletedCategory = new Category(1, "Name", "Description", 1);
            var CategoryList = new List<Category>()
            {
                deletedCategory,
                new Category(1, "Name", "Description", 1)
        };

            categoryRepo.GetById(CategoryId).Returns(deletedCategory);
            categoryRepo.When(d => d.Delete(deletedCategory))
                .Do(d => CategoryList.Remove(deletedCategory));
            categoryRepo.GetAll().Returns(CategoryList);

            var result = underTest.Delete(CategoryId);

            Assert.DoesNotContain(deletedCategory, result); /*Does not work in all cases*/
            //Assert.All(result, item => Assert.Contains("Second item", item.Name));
        }

        [Fact]
        public void Put_Updates_Category()
        {
            var originalCategory = new Category(1, "Name", "Description", 1); ;
            var expectedCategory = new List<Category>()
            {
                originalCategory
            };
            var updatedCategory = new Category(1, "Name", "Description", 1);

            categoryRepo.When(t => categoryRepo.Update(updatedCategory))
                .Do(Callback.First(t => expectedCategory.Remove(originalCategory))
                .Then(t => expectedCategory.Add(updatedCategory)));
            categoryRepo.GetAll().Returns(expectedCategory);

            var result = underTest.Put(updatedCategory);

            // Assert.Equal(expectedTodos, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Name));
        }

    }
}
