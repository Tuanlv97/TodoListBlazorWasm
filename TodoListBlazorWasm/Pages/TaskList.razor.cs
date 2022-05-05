using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.Models;
using TodoListBlazorWasm.Services;

namespace TodoListBlazorWasm.Pages
{
    public partial class TaskList
    {
        [Inject] private ITaskApiClient TaskApiClient { set; get; }

        private List<TaskDto> Tasks;
        private TaskListSearch TaskListSearch = new TaskListSearch();

        protected override async Task OnInitializedAsync()
        {
            Tasks = await TaskApiClient.GetTaskList(TaskListSearch);
        }

        public async Task SearchTask(TaskListSearch taskListSearch)
        {
            TaskListSearch = taskListSearch;
            Tasks = await TaskApiClient.GetTaskList(TaskListSearch);
        }
    }

}
