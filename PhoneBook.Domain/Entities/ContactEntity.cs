using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain.Entities
{
    public class ContactEntity
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public List<PhoneEntity> Phones { get; set; }
    }
}
