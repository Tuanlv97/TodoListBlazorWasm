using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.Api.Entities;

namespace TodoList.Api.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetUserList();
    }
}