using Core;
using Core.Repositories.Abstract;
using Data.Contexts;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NotesAppDbContext _context;
        private UserRepository _userRepository;
        private NoteRepository _noteRepository;

        public IUserRepository Users => _userRepository ?? new UserRepository(_context);
        public INoteRepository Notes => _noteRepository ?? new NoteRepository(_context);

        public UnitOfWork(NotesAppDbContext context)
        {
            _context = context;
        }
        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
