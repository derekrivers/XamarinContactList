using System;
using System.Threading.Tasks;

namespace ContactList.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        Task CommitAsync();
    }
}
