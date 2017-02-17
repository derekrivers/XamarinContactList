using System;

namespace ContactList.Domain
{
    public class Contact : Entity
    {
        public string Name { get; set; }
        public byte[] Image { get; set; }
    }

    public class Entity
    {
        public Guid Id { get; set; }
    }
}
