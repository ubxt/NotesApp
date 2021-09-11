using Core.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        INoteRepository Notes { get; }
        Task<int> CommitAsync();
    }
}
