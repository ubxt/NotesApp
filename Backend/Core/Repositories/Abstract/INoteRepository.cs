using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Abstract
{
    public interface INoteRepository:IRepository<Note>
    {
        Task<IEnumerable<Note>> GetAllWithUsersAsync();
        Task<Note> GetByIdWithUsersAsync(int id);
        Task<IEnumerable<Note>> GetAllWithUserByUserIdAsync(int userId);

    }
}
