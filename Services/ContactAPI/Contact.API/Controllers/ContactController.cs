using Contact.API.Infrastructure;
using Contact.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }


        [HttpGet("{Id}")]
        public ContactDTO Get(int Id)
        {
            return _contactService.GetContactById(Id);
        }

        [HttpGet("")]
        public List<ContactDTO> GetAll()
        {
            return _contactService.GetAll();
        }
        
    }
}
