using System;

namespace ContactList.ApplicationModels.Response
{
    public class ContactResponseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
    }
}
