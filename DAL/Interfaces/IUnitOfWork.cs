using System;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IUserRepository UserRepository { get; }

        Task<int> Commit();
    }
}
