using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Entities;
using PhoneBook.Domain.Interfaces;
using PhoneBook.InfraData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.InfraData.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private ApplicationDbContext _context;

        public ContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ContactEntity> CreateAsync(ContactEntity contact)
        {
            _context.Add(contact);
            await _context.SaveChangesAsync();
            return contact;
        }
        public async Task<IEnumerable<ContactEntity>> GetContactsAsync()
        {
            return await _context.Contatos.ToListAsync();
        }

        public async Task<ContactEntity> RemoveAsync(ContactEntity contact)
        {
            _context.Remove(contact);
            await _context.SaveChangesAsync();
            return contact;
        }

        public async Task<ContactEntity> UpdateAsync(ContactEntity contact)
        {
            _context.Update(contact);
            await _context.SaveChangesAsync();
            return contact;
        }
    }
}
