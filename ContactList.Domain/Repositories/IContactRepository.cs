using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactList.Domain.Repositories
{
    public interface IContactRepository
    {
        Contact FindById(Guid id);
        IEnumerable<Contact> GetAllContacts();
        void Add(Contact contact);
    }
}
