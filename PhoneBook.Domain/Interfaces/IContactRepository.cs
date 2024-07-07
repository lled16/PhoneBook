using PhoneBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain.Interfaces
{
    public interface IContactRepository
    {
        Task<ContactEntity> CreateAsync(ContactEntity contact);
        Task<List<ContactEntity>> GetContactsAsync();
        Task<List<ContactEntity>> GetContactsByName(string name);
        void RemoveAsync(int contact);
        Task<ContactEntity> UpdateAsync(ContactEntity contact, int idContact);
    }
}
