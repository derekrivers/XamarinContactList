using System.ComponentModel.DataAnnotations;

namespace ContactList.ApplicationModels.Input
{
    public class ContactInputModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        public byte[] Image { get; set; }
    }
}
