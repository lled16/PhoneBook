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
        Task<IEnumerable<ContactEntity>> GetContactsAsync();
        Task<ContactEntity> RemoveAsync(ContactEntity contact);
        Task<ContactEntity> UpdateAsync(ContactEntity contact);
    }
}
