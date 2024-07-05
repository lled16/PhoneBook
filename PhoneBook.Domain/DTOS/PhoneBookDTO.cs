using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Application.DTOS
{
    public class PhoneBookDTO
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public IEnumerable<string> Phone { get; set; }
    }
}
