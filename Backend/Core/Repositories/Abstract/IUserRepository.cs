using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Abstract
{
    public interface IUserRepository:IRepository<User>
    {
        Task<IEnumerable<User>> GetAllWithNotesAsync();
        Task<User> GetByIdWithNotesAsync(int id);
        Task<User> GetByEmailWithNotesAsync(string email);
        Task<IEnumerable<User>> GetAllWithNotesByNoteIdAsync(int noteId);

    }
}
