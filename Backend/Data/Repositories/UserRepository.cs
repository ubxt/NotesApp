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
    public class UserRepository : Repository<User>, IUserRepository
    {
        private NotesAppDbContext NotesAppDbContext { 
            get { return Context as NotesAppDbContext; } 
        }
        public UserRepository(DbContext context) : base(context)
        { }
        public async Task<IEnumerable<User>> GetAllWithNotesAsync()
        {
            return await NotesAppDbContext.Users
                .Include(a => a.Notes)
                .ToListAsync();
        }
        public Task<User> GetByIdWithNotesAsync(int id)
        {
            return NotesAppDbContext.Users
                .Include(u => u.Notes)
                .SingleOrDefaultAsync(u => u.Id == id);
        }
        public Task<User> GetByEmailWithNotesAsync(string email)
        {
            return NotesAppDbContext.Users
                .Include(u => u.Notes)
                .SingleOrDefaultAsync(u => u.Email == email);
        }
        public async Task<IEnumerable<User>> GetAllWithNotesByNoteIdAsync(int noteId)
        {
            return await NotesAppDbContext.Users
                                .Include(u => u.Notes)
                                .Where(u => u.Notes.Any(n=>n.Id==noteId))
                                .ToListAsync();
        }
    }
}
