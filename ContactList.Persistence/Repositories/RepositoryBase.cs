using ContactList.Domain;
using System;
using System.Data.Entity;

namespace ContactList.Persistence.Repositories
{
    public class RepositoryBase
    {
        private readonly MyDbUnitOfWork _myUnitOfWork;

        public RepositoryBase(IUnitOfWork uow)
        {
            _myUnitOfWork = uow as MyDbUnitOfWork;

            if(_myUnitOfWork == null)
            {
                throw new InvalidOperationException("Must be MyDbUnitOfWork");
            }
        }

        protected DbSet<T> GetDbSet<T>() where T : Entity
        {
            return _myUnitOfWork.Set<T>();
        }
    }
}
