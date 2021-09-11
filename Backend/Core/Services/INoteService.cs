using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface INoteService
    {
        Task<IEnumerable<Note>> GetAllWithUsers();
        Task<Note> GetById(int id);
        Task<IEnumerable<Note>> GetByUserId(int userId);
        Task<Note> Create(Note note);
        Task Update(Note noteToUpdate, Note newNote);
        Task Delete(Note note);
    }
}
