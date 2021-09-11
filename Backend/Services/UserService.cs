using Core;
using Core.Entities;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<User> Create(User user)
        {
            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.CommitAsync();
            return user;
        }
        public async Task Delete(User user)
        {
            _unitOfWork.Users.Remove(user);
            await _unitOfWork.CommitAsync();
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _unitOfWork.Users.GetAllAsync();
        }
        public async Task<User> GetById(int id)
        {
            return await _unitOfWork.Users.GetByIdAsync(id);
        }
        public async Task<User> GetByEmail(string email)
        {
            return await _unitOfWork.Users.GetByEmailWithNotesAsync(email);
        }
        public async Task Update(User userToUpdate, User newUser)
        {
            userToUpdate.FirstName = newUser.FirstName;
            userToUpdate.LastName = newUser.LastName;
            userToUpdate.Email = newUser.Email;

            await _unitOfWork.CommitAsync();
        }
    }
}
