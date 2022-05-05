﻿using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;
using TodoList.Models.Enums;
using TodoListBlazorWasm.Services;

namespace TodoListBlazorWasm.Pages
{
    public partial class TaskList
    {
        [Inject] private ITaskApiClient TaskApiClient { set; get; }
        [Inject] private IUserApiClient UserApiClient { set; get; }
        [Inject] private IToastService ToastService { set; get; }

        private List<TaskDto> Tasks;
        private List<AssigneeDto> Assignees;
        private TaskListSearch TaskListSearch = new TaskListSearch();

        protected override async Task OnInitializedAsync()
        {
            Tasks = await TaskApiClient.GetTaskList();
            Assignees = await UserApiClient.GetAssignees();
        }
        private async Task SearchForm(EditContext context)
        {
            ToastService.ShowInfo("Search completed", "Info");
            Tasks = await TaskApiClient.GetTaskList();
        }
    }

    public class TaskListSearch
    {
        public string Name { get; set; }
        public Guid AssigneeId { get; set; }
        public Priority Priority { get; set; }
    }
}
