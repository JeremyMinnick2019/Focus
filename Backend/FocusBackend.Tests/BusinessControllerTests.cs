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
    public class BusinessControllerTests
    {
        private BusinessController underTest;
        IRepository<Business> businessRepo;

        public BusinessControllerTests()
        {
            businessRepo = Substitute.For<IRepository<Business>>();
            underTest = new BusinessController(businessRepo);
        }

        [Fact]
        public void Get_Returns_List_of_Businesss()
        {
            var expectedBusinesss = new List<Business>()
            {
                new Business(1, "Name", "Industry", "Image", 1),
                new Business(2, "Name", "Industry", "Image", 1)
        };
            businessRepo.GetAll().Returns(expectedBusinesss);

            var result = underTest.Get();

            Assert.Equal(expectedBusinesss, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_Business()
        {
            var newBusiness = new Business(1, "Name", "Industry", "Image", 1);
            var BusinessList = new List<Business>();

            businessRepo.When(t => t.Create(newBusiness))
                .Do(t => BusinessList.Add(newBusiness));

            businessRepo.GetAll().Returns(BusinessList);

            var result = underTest.Post(newBusiness);

            Assert.Contains(newBusiness, result);
        }

        [Fact]
        public void Delete_Removes_Business()
        {
            var BusinessId = 1;
            var deletedBusiness = new Business(1, "Name", "Industry", "Image", 1);
            var BusinessList = new List<Business>()
            {
                deletedBusiness,
                new Business(1, "Name", "Industry", "Image", 1)
        };

            businessRepo.GetById(BusinessId).Returns(deletedBusiness);
            businessRepo.When(d => d.Delete(deletedBusiness))
                .Do(d => BusinessList.Remove(deletedBusiness));
            businessRepo.GetAll().Returns(BusinessList);

            var result = underTest.Delete(BusinessId);

            Assert.DoesNotContain(deletedBusiness, result); /*Does not work in all cases*/
            //Assert.All(result, item => Assert.Contains("Second item", item.Name));
        }

        [Fact]
        public void Put_Updates_Business()
        {
            var originalBusiness = new Business(1, "Name", "Industry", "Image", 1); ;
            var expectedBusiness = new List<Business>()
            {
                originalBusiness
            };
            var updatedBusiness = new Business(1, "Name", "Industry", "Image", 1);

            businessRepo.When(t => businessRepo.Update(updatedBusiness))
                .Do(Callback.First(t => expectedBusiness.Remove(originalBusiness))
                .Then(t => expectedBusiness.Add(updatedBusiness)));
            businessRepo.GetAll().Returns(expectedBusiness);

            var result = underTest.Put(updatedBusiness);

            // Assert.Equal(expectedTodos, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Name));
        }

    }

}
