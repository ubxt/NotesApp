using Core.Entities;
using Core.Repositories.Abstract;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    class NoteRepository : Repository<Note>, INoteRepository
    {
        private NotesAppDbContext NotesAppDbContext
        {
            get { return Context as NotesAppDbContext; }
        }
        public NoteRepository(NotesAppDbContext context)
             : base(context)
        { }
        public async Task<IEnumerable<Note>> GetAllWithUsersAsync()
        {
            return await NotesAppDbContext.Notes
                .Include(m => m.Users)
                .ToListAsync();
        }
        public async Task<Note> GetByIdWithUsersAsync(int id)
        {
            return await NotesAppDbContext.Notes
                .Include(n => n.Users)
                .SingleOrDefaultAsync(n => n.Id == id); ;
        }
        public async Task<IEnumerable<Note>> GetAllWithUserByUserIdAsync(int userId)
        {
            return await NotesAppDbContext.Notes
                               .Include(n => n.Users)
                               .Where(n => n.Users.Any(u => u.Id == userId))
                               .ToListAsync();
        }
    }
}
