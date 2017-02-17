using ContactList.Domain;
using System.Data.Entity.ModelConfiguration;

namespace ContactList.Persistence.EntityMaps
{
    public class ContactsMap : EntityTypeConfiguration<Contact>
    {


        public ContactsMap()
        {
            ToTable("Contacts");
            HasKey(c => c.Id);
            Property(contact => contact.Name).HasMaxLength(100).IsRequired();
        }

    }
}
