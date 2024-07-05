using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.DTOS;
using PhoneBook.Application.Interfaces;

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

        [HttpGet]
        public IActionResult GetRegisters()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult PostRegister()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRegister()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRegister()
        {
            return Ok();
        }
    }
}
