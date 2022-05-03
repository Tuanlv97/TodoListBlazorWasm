using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;
using TodoListBlazorWasm.Services;

namespace TodoListBlazorWasm.Pages
{
    public partial class TaskList
    {
        [Inject] private ITaskApiClient taskApiClient { set; get; }
        private List<TaskDto> Tasks;

        protected override async Task OnInitializedAsync()
        {
            Tasks = await taskApiClient.GetTaskList();
        }
    }
}
