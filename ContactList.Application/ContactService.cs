using System;
using System.Collections.Generic;
using ContactList.ApplicationModels.Response;
using ContactList.Domain.Repositories;
using ContactList.Domain;
using System.Linq;
using System.Threading.Tasks;
using ContactList.ApplicationModels.Input;

namespace ContactList.Application
{
    public class ContactService : IContactService
    {
        private IContactRepository _contactRepo;
        private IUnitOfWork _unitOfWork;

        public ContactService(IContactRepository contactRepo, IUnitOfWork unitOfWork)
        {
            _contactRepo = contactRepo;
            _unitOfWork = unitOfWork;
        }

        public ContactResponseModel FindById(Guid id)
        {
            var contact = _contactRepo.FindById(id);

            if (contact != null)
            {
                return new ContactResponseModel()
                {
                    Id = contact.Id,
                    Name = contact.Name,
                    Image = contact.Image
                };
            }

            return null;
        }

        public IEnumerable<ContactResponseModel> GetAllContacts()
        {
            IEnumerable<Contact> contacts = _contactRepo.GetAllContacts();

            return contacts.Select(contact => new ContactResponseModel()
            {
                Id = contact.Id,
                Name = contact.Name,
                Image = contact.Image
            });

        }

        public async Task<ContactResponseModel> SaveContactAsync(ContactInputModel inputModel)
        {
            var contact = new Contact()
            {
                Name = inputModel.Name,
                Image = inputModel.Image
            };

            _contactRepo.Add(contact);

            await _unitOfWork.CommitAsync();

            return new ContactResponseModel
            {
                Id = contact.Id,
                Name = contact.Name,
                Image = contact.Image
            };
        }
    }
}
