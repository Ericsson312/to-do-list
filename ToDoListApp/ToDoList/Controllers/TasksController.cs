using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoListDTO;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private ITaskRepository _taskRepository;

        public TasksController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<List<ToDoTask>> GetTasks(int userId)
        {
            return _taskRepository.Tasks().Where(x => x.UserId == userId).ToList();
        }

        [Authorize]
        [HttpGet]
        public ActionResult<ToDoTask> GetTaskById(int userId)
        {
            return _taskRepository.Tasks().Where(x => x.UserId == userId).SingleOrDefault();
        }
    }
}
