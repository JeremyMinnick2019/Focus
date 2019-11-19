using System;
using System.Collections.Generic;
using System.Text;

namespace FocusBackend.Tests
{
    public class UserControllerTests
    {
        private UserController underTest;
        IRepository<User> userRepo;

        public UserControllerTests()
        {
            userRepo = Substitute.For<IRepository<User>>();
            underTest = new UserController(userRepo);
        }

        [Fact]
        public void Get_Returns_List_of_Users()
        {
            var expectedUsers = new List<User>()
            {
                new User(1, "Name", "Email", "Phone", "Image"),
                new User(1, "Name", "Email", "Phone", "Image")
        };
            userRepo.GetAll().Returns(expectedUsers);

            var result = underTest.Get();

            Assert.Equal(expectedUsers, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_User()
        {
            var newUser = new User(1, "Name", "Email", "Phone", "Image");
            var UserList = new List<User>();

            userRepo.When(t => t.Create(newUser))
                .Do(t => UserList.Add(newUser));

            userRepo.GetAll().Returns(UserList);

            var result = underTest.Post(newUser);

            Assert.Contains(newUser, result);
        }

        [Fact]
        public void Delete_Removes_User()
        {
            var UserId = 1;
            var deletedUser = new User(1, "Name", "Email", "Phone", "Image");
            var UserList = new List<User>()
            {
                deletedUser,
                new User(1, "Name", "Email", "Phone", "Image")
        };

            userRepo.GetById(UserId).Returns(deletedUser);
            userRepo.When(d => d.Delete(deletedUser))
                .Do(d => UserList.Remove(deletedUser));
            userRepo.GetAll().Returns(UserList);

            var result = underTest.Delete(UserId);

            Assert.DoesNotContain(deletedUser, result); /*Does not work in all cases*/
            //Assert.All(result, item => Assert.Contains("Second item", item.Name));
        }

        [Fact]
        public void Put_Updates_User()
        {
            var originalUser = new User(1, "Name", "Email", "Phone", "Image"); ;
            var expectedUser = new List<User>()
            {
                originalUser
            };
            var updatedUser = new User(1, "Name", "Email", "Phone", "Image");

            userRepo.When(t => userRepo.Update(updatedUser))
                .Do(Callback.First(t => expectedUser.Remove(originalUser))
                .Then(t => expectedUser.Add(updatedUser)));
            userRepo.GetAll().Returns(expectedUser);

            var result = underTest.Put(updatedUser);

            // Assert.Equal(expectedTodos, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Name));
        }

    }
}
