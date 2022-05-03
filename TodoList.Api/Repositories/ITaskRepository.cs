using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.Api.Entities;
using TodoList.Models;
using TodoList.Models.SeedWork;
using Task = TodoList.Api.Entities.Task;

namespace TodoList.Api.Repositories
{
    public interface ITaskRepository
    {
        Task<PagedList<Task>> GetTaskList(TaskListSearch taskListSearch);

        Task<PagedList<Task>> GetTaskListByUserId(Guid userId, TaskListSearch taskListSearch);

        Task<Task> Create(Task task);

        Task<Task> Update(Task task);

        Task<Task> Delete(Task task);

        Task<Task> GetById(Guid id);

        Task<IEnumerable<Task>> GetAllTask();
    }
}
