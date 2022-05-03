﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoListBlazorWasm.Services
{
   public interface ITaskApiClient
    {
        Task<List<TaskDto>> GetTaskList();
    }
}
