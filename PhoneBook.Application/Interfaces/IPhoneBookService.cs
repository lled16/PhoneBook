using PhoneBook.Application.DTOS;
using PhoneBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Application.Interfaces
{
    public interface IPhoneBookService
    {
        Task<List<ContactEntity>> GetPhonesBook();
        Task<List<ContactEntity>> GetContactsByName(string name);
        Task<ContactEntity> PostPhonesBook(ContactDTO contact);
        Task DeleteContact(int contact);
    }
}
