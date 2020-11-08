using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class FakeTaskRepository : ITaskRepository
    {
        public IQueryable<ToDoTask> Tasks()
        {
            List<ToDoTask> myTasks = new List<ToDoTask>()
            {
                new ToDoTask { UserId = 1, Name = "Wash Car" , Description = "Wash car with clinning agent" , TimePublished = new DateTime(), IsComplite = false}
            };

            return myTasks.AsQueryable<ToDoTask>();
        }
    }
}
