using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListDTO;

namespace ToDoList.Models
{
    public class FakeUserRepository : IUserRepository
    {
        public IQueryable<User> Users()
        {
            List<User> users = new List<User>()
            {
                new User
                {
                    Id = 1,
                    FirstName = "Tom",
                    LastName = "Hardy",
                    Email = "tomhardy@gmail.com",
                    Password = "12345Tomtom!",
                    UserName = "Tommy333"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Eva",
                    LastName = "Green",
                    Email = "evagreen@gmail.com",
                    Password = "eva555eva!",
                    UserName = "EvaGreen"
                }
            };

            return users.AsQueryable<User>();
        }
    }
}
