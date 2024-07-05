using PhoneBook.Application.DTOS;
using PhoneBook.Domain.Entities;
using PhoneBook.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain.Mappings
{
    public class EntityToDTOMapper : IEntityToDTOMapper
    {
        public async Task<PhoneBookDTO> EntityToDTO(ContactEntity contactEntity)
        {
            PhoneBookDTO phoneBookDTO = new PhoneBookDTO()
            {
                Name = contactEntity.Name,
                Phone = contactEntity.Phones,
            };
            return phoneBookDTO;
        }
    }
}
