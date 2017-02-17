using ContactList.Application;
using ContactList.ApplicationModels.Input;
using ContactList.ApplicationModels.Response;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace ContactList.Api.Controllers
{
    [RoutePrefix("contact")]
    public class ContactController : ApiController
    {

        private IContactService _contactService;


        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IEnumerable<ContactResponseModel> Get()
        {
            return _contactService.GetAllContacts();
        }

        public ContactResponseModel Get(Guid id)
        {
            return _contactService.FindById(id);
        }

        public void Post([FromBody] ContactInputModel inputModel)
        {

        }

     
    }
}