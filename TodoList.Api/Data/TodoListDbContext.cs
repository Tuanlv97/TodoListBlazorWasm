using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using TodoList.Api.Entities;

namespace TodoList.Api.Data
{
    public class TodoListDbContext : IdentityDbContext<User, Role, Guid>
    {
        public TodoListDbContext(DbContextOptions<TodoListDbContext> options) : base(options)
        {

        }

        public DbSet<Task> Tasks { set; get; }
    }
}
