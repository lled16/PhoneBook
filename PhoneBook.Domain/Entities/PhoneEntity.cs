using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Domain.Entities
{
    public class PhoneEntity
    {
        public int Id { get; set; }
        [Required]
        public string Phones { get; set; }
        [Required]
        public virtual ContactEntity Contact { get; set; }

    }
}
