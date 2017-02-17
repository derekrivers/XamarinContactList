using ContactList.Domain.Repositories;
using System;
using ContactList.Domain;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactList.Persistence.Repositories
{
    public class ContactRepository : RepositoryBase, IContactRepository
    {
        public ContactRepository(IUnitOfWork uow) 
            : base(uow)
        {
        }

        public void Add(Contact contact)
        {
            GetDbSet<Contact>().Add(contact);
        }

        public Contact FindById(Guid id)
        {
            return GetDbSet<Contact>().Find(id);
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return GetDbSet<Contact>().AsQueryable();
        }
    }
}
