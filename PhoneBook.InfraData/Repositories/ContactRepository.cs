using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Newtonsoft.Json;
using PhoneBook.Domain.Entities;
using PhoneBook.Domain.Interfaces;
using PhoneBook.InfraData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

            _context.Contatos.Add(contact);
            _context.SaveChanges();

            if (contact.Phones != null && contact.Phones.Any())
            {
                foreach (var phone in contact.Phones)
                {
                    var existingPhone = _context.Telefones.FirstOrDefault(p => p.PhoneNumber == phone.PhoneNumber);

                    if (existingPhone != null)
                    {
                        phone.PhoneId = existingPhone.PhoneId;
                        phone.ContactId = contact.ContactId;


                        _context.Telefones.Attach(existingPhone);
                    }
                    else
                    {
                        phone.PhoneId = null;
                        phone.ContactId = contact.ContactId;
                        var newPhone = new PhoneEntity
                        {
                            PhoneNumber = phone.PhoneNumber,
                            ContactId = phone.ContactId
                        };

                        _context.Telefones.Add(newPhone);
                    }
                }
            }

            _context.SaveChanges();

            return contact;
        }
        public async Task<List<ContactEntity>> GetContactsAsync()
        {
            List<ContactEntity> contacts = _context.Contatos
             .Include(c => c.Phones)
             .ToList();

            return contacts;
        }
        public async Task<List<ContactEntity>> GetContactsByName(string name)
        {
            var contacts = _context.Contatos
                                .Where(c => c.Name.Contains(name))
                                .Include(c => c.Phones)
                                .ToList();

            return contacts;
        }

        public async Task RemoveAsync(int contact)
        {
            ContactEntity contactRemove = _context.Contatos
           .Include(c => c.Phones)
           .FirstOrDefault(c => c.ContactId == contact);



            if (contactRemove != null)
            {
                var contactInfo = new
                {
                    contactRemove.ContactId,
                    contactRemove.Name,
                    Phones = contactRemove.Phones.Select(p => new { p.PhoneId, p.PhoneNumber })
                };

                string contactJson = JsonConvert.SerializeObject(contactInfo, Formatting.Indented);

                string logDirectory = Path.Combine(Directory.GetCurrentDirectory(), "log");

                if (!Directory.Exists(logDirectory))
                {
                    Directory.CreateDirectory(logDirectory);
                }

                string logFilePath = Path.Combine(logDirectory, $"contact_{contact}_removed.txt");

                await File.WriteAllTextAsync(logFilePath, contactJson);
            }
            else
            {
                throw new Exception($"Contato com ID {contact} não encontrado.");
            }


            if (contactRemove != null)
            {
                _context.Telefones.RemoveRange(contactRemove.Phones);
                _context.Contatos.Remove(contactRemove);

                _context.SaveChanges();
            }
        }

        public async Task<ContactEntity> UpdateAsync(ContactEntity contact, int idContact)
        {
            var existingContact = await _context.Contatos
                .Include(c => c.Phones)
                .FirstOrDefaultAsync(c => c.ContactId == idContact);

            existingContact.Name = contact.Name ?? existingContact.Name;
            existingContact.Age = contact.Age != 0 ? contact.Age : existingContact.Age;

            if (contact.Phones != null && contact.Phones.Any())
            {
                existingContact.Phones.Clear();

                foreach (var phone in contact.Phones)
                {
                    phone.ContactId = existingContact.ContactId;
                    existingContact.Phones.Add(phone);
                }

                var existingPhone = _context.Telefones.Where(t => t.ContactId == idContact);

                foreach (var number in existingPhone)
                {
                    _context.Telefones.Remove(number);
                }
            }
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {

                throw new Exception("Error update contact", ex);
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error update contact", ex);
            }

            return existingContact;
        }
    }
}
