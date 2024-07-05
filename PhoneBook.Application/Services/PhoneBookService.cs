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



        public async Task<PhoneBookDTO> GetPhonesBook()
        {
            List<PhoneBookDTO> phoneBooks = new List<PhoneBookDTO>();

            var contacts = await _contactRepository.GetContactsAsync();

          
            await _entityToDTOMapper.EntityToDTO(phonesByContact, contact);
            



            return null;

        }
    }
}