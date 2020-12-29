using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListDTO;

namespace ToDoList.Models
{
    public class FakeTaskRepository : ITaskRepository
    {
        public IQueryable<ToDoTask> Tasks()
        {
            List<ToDoTask> tasks = new List<ToDoTask>()
            {
                new ToDoTask 
                { 
                    Id = 1,
                    UserId = 1, 
                    Name = "Wash car" , 
                    Description = "Wash car with clinning agent", 
                    TimePublished = new DateTime(), 
                    IsComplite = false
                },
                new ToDoTask
                {
                    Id = 2,
                    UserId = 1,
                    Name = "Homework" ,
                    Description = "Finish all university assignments",
                    TimePublished = new DateTime(),
                    IsComplite = false
                },
                new ToDoTask
                {
                    Id = 3,
                    UserId = 2,
                    Name = "Clean the room" ,
                    Description = "Clean floor, table and windows",
                    TimePublished = new DateTime(),
                    IsComplite = false
                }
            };

            return tasks.AsQueryable<ToDoTask>();
        }
    }
}
