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
    public class ActivityControllerTests
    {
        private ActivityController underTest;
        IRepository<Activity> activityRepo;

        public ActivityControllerTests()
        {
            activityRepo = Substitute.For<IRepository<Activity>>();
            underTest = new ActivityController(activityRepo);
        }

        [Fact]
        public void Get_Returns_List_of_Activities()
        {
            var expectedActivitys = new List<Activity>()
            {
                new Activity(1, "Name", "Description", DateTime.Now, DateTime.Now, 1, 1, 1),
                new Activity(2, "Name", "Description", DateTime.Now, DateTime.Now, 1, 1, 1)
        };
            activityRepo.GetAll().Returns(expectedActivities);

            var result = underTest.Get();

            Assert.Equal(expectedActivities, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_Activity()
        {
            var newActivity = new Activity(1, "Name", "Description", DateTime.Now, DateTime.Now, 1, 1, 1);
            var ActivityList = new List<Activity>();

            ActivityRepo.When(t => t.Create(newActivity))
                .Do(t => ActivityList.Add(newActivity));

            ActivityRepo.GetAll().Returns(ActivityList);

            var result = underTest.Post(newActivity);

            Assert.Contains(newActivity, result);
        }

        [Fact]
        public void Delete_Removes_Activity()
        {
            var ActivityId = 1;
            var deletedActivity = new Activity(1, "Name", "Description", DateTime.Now, DateTime.Now, 1, 1, 1);
            var ActivityList = new List<Activity>()
            {
                deletedActivity,
                new Activity(1, "Name", "Description", DateTime.Now, DateTime.Now, 1, 1, 1)
        };

            ActivityRepo.GetById(ActivityId).Returns(deletedActivity);
            ActivityRepo.When(d => d.Delete(deletedActivity))
                .Do(d => ActivityList.Remove(deletedActivity));
            ActivityRepo.GetAll().Returns(ActivityList);

            var result = underTest.Delete(ActivityId);

            Assert.DoesNotContain(deletedActivity, result); /*Does not work in all cases*/
            //Assert.All(result, item => Assert.Contains("Second item", item.Name));
        }

        [Fact]
        public void Put_Updates_Activity()
        {
            var originalActivity = new Activity(1, "Name", "Description", DateTime.Now, DateTime.Now, 1, 1, 1); ;
            var expectedActivity = new List<Activity>()
            {
                originalActivity
            };
            var updatedActivity = new Activity(1, "Name", "Description", DateTime.Now, DateTime.Now, 1, 1, 1);

            ActivityRepo.When(t => ActivityRepo.Update(updatedActivity))
                .Do(Callback.First(t => expectedActivity.Remove(originalActivity))
                .Then(t => expectedActivity.Add(updatedActivity)));
            ActivityRepo.GetAll().Returns(expectedActivity);

            var result = underTest.Put(updatedActivity);

            // Assert.Equal(expectedTodos, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Name));
        }

    }
}
