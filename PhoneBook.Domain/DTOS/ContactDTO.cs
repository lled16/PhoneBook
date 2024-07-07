using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PhoneBook.Application.DTOS
{
    public class ContactDTO
    {
        [JsonIgnore]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public List<string> Phone { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
