using Contact.API.Infrastructure;
using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int id)
        {
            return new ContactDTO
            {
                Id = id,
                FirstName = "John",
                LastName = "Axmedli"
            };
        }

        public List<ContactDTO> GetAll()
        {
            return new List<ContactDTO>()
            {
                new ContactDTO
                {
                     Id= new Random().Next(1,100000),
                     FirstName="Ali",
                     LastName="Aliyev"
                },
                new ContactDTO
                {
                     Id= new Random().Next(1,100000),
                     FirstName="Aysel",
                     LastName="Aliyeva"
                },
                new ContactDTO
                {
                     Id= new Random().Next(1,100000),
                     FirstName="Tural",
                     LastName="Aliyev"
                }
            };
        }
    }
}
