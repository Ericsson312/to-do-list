﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListDTO;

namespace ToDoList.Models
{
    public interface ITaskRepository
    {
        IQueryable<ToDoTask> Tasks();
    }
}
