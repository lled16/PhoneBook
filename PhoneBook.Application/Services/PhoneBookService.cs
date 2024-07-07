using PhoneBook.Application.DTOS;
using PhoneBook.Application.Interfaces;
using PhoneBook.Domain.Entities;
using PhoneBook.Domain.Interfaces;

namespace PhoneBook.Application.Services
{
    public class PhoneBookService : IPhoneBookService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IPhonesRepository _phonesRepository;
        private readonly IEntityToDTOMapper _entityToDTOMapper;
        public PhoneBookService(IContactRepository contactRepository, IPhonesRepository phonesRepository)
        {
            _contactRepository = contactRepository;
            _phonesRepository = phonesRepository;
        }



        public async Task<List<ContactEntity>> GetPhonesBook()
        {
            List<ContactEntity> contacts = await _contactRepository.GetContactsAsync();

            return contacts;
        }    
        
        public async Task<List<ContactEntity>> GetContactsByName(string name)
        {
            List<ContactEntity> contacts = await _contactRepository.GetContactsByName(name);

            return contacts;
        }

        public async Task<ContactEntity> PostPhonesBook(ContactDTO contact)
        {
            List<PhoneEntity> contactNumbers = new List<PhoneEntity>();

            foreach (var number in contact.Phone)
            {
                PhoneEntity phoneEntity = new PhoneEntity();
                phoneEntity.PhoneNumber = number;
                contactNumbers.Add(phoneEntity);
            }

            ContactEntity contactEntity = new ContactEntity();
            contactEntity.Name = contact.Name;
            contactEntity.Age = contact.Age;
            contactEntity.Phones = contactNumbers;

            ContactEntity contactSave = await _contactRepository.CreateAsync(contactEntity);

            return contactSave;
        }

        public async Task DeleteContact(int contact)
        {
            _contactRepository.RemoveAsync(contact);
        }
    }
}