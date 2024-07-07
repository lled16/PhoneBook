using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.DTOS;
using PhoneBook.Application.Interfaces;
using PhoneBook.Domain.Entities;

namespace PhoneBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneBookController : ControllerBase
    {
        private readonly IPhoneBookService _phoneBookService;

        public PhoneBookController(IPhoneBookService phoneBookService)
        {
            _phoneBookService = phoneBookService;
        }

        [HttpGet("contacts")]
        public async Task<IActionResult> GetRegisters()
        {
            var contacts = await _phoneBookService.GetPhonesBook();

            return Ok(contacts);
        }

        [HttpGet("contacts/{name}")]
        public async Task<IActionResult> GetContactByName(string name)
        {
            var contact = await _phoneBookService.GetContactsByName(name);
            return Ok(contact);
        }

        [HttpPost]
        public IActionResult PostRegister([FromBody] ContactDTO newContact)
        {
            var contact = _phoneBookService.PostPhonesBook(newContact);
            return Ok(contact);
        }
        [HttpPut]
        public IActionResult UpdateRegister()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRegister(int idContact)
        {
            _phoneBookService.DeleteContact(idContact);
            return Ok();
        }
    }
}
