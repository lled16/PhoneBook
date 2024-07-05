using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain.Entities
{
    public class PhoneEntity
    {
        public int Id { get; set; }
        [Required]
        public string[] Phones { get; set; }
        [Required]
        public virtual ContactEntity Contact { get; set; }

    }
}
