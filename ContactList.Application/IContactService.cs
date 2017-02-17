using ContactList.ApplicationModels.Input;
using ContactList.ApplicationModels.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactList.Application
{
    public interface IContactService
    {
        ContactResponseModel FindById(Guid id);
        IEnumerable<ContactResponseModel> GetAllContacts();

        Task<ContactResponseModel> SaveContactAsync(ContactInputModel inputModel);
    }
}
