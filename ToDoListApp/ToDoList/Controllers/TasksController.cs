using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Helper;
using ToDoList.Models;
using ToDoListDTO;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;

        public TasksController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<List<ToDoTask>> GetTasks()
        {
            var user = (User)HttpContext.Items["User"];

            return _taskRepository.Tasks().Where(x => x.UserId == user.Id).ToList();
        }

        [Authorize]
        [HttpGet("{taskId}")]
        public ActionResult<ToDoTask> GetTaskById(int taskId)
        {
            var user = (User)HttpContext.Items["User"];
            var myTask = _taskRepository.Tasks().Where(x => x.Id == taskId && x.UserId == user.Id).SingleOrDefault();

            if (myTask == null)
            {
                return NotFound();
            }

            return myTask;
        }
    }
}
