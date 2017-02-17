using ContactList.Domain;
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Threading.Tasks;

namespace ContactList.Persistence
{
    public class MyDbUnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _context;

        public MyDbUnitOfWork()
        {
            _context = new MyDbContext();
        }

        public void Commit()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEntityValidationException)
            {
                throw dbEntityValidationException;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task CommitAsync()
        {
            try
            {
                return _context.SaveChangesAsync();
            }
            catch (DbEntityValidationException dbEntityValidationException)
            {
                throw dbEntityValidationException;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        internal DbSet<T> Set<T>() where T : Entity
        {
            return _context.Set<T>();
        }
    }
}
