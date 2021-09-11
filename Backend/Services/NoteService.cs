using Core;
using Core.Entities;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class NoteService : INoteService
    {
        private readonly IUnitOfWork _unitOfWork;
        public NoteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Note> Create(Note note)
        {
            await _unitOfWork.Notes.AddAsync(note);
            await _unitOfWork.CommitAsync();
            return note;
        }

        public async Task Delete(Note note)
        {
            _unitOfWork.Notes.Remove(note);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Note>> GetAllWithUsers()
        {
            return await _unitOfWork.Notes.GetAllWithUsersAsync();
        }

        public async Task<Note> GetById(int id)
        {
            return await _unitOfWork.Notes.GetByIdWithUsersAsync(id);
        }

        public async Task<IEnumerable<Note>> GetByUserId(int userId)
        {
            return await _unitOfWork.Notes.GetAllWithUserByUserIdAsync(userId);
        }

        public async Task Update(Note noteToUpdate, Note newNote)
        {
            noteToUpdate.Title = newNote.Title;
            noteToUpdate.Content = newNote.Content;

            await _unitOfWork.CommitAsync();
        }
    }
}
