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
        public static List<ContactDTO> AllContacts{ get; set; }  =new List<ContactDTO>()
            {
                new ContactDTO
                {
                     Id= new Random().Next(1,100000),
                     FirstName="Ali",
                     LastName="Aliyev"
                },
                new ContactDTO
                {
                    Id = new Random().Next(1, 100000),
                    FirstName = "Aysel",
                    LastName = "Aliyeva"
                },
                new ContactDTO
                {
                    Id = new Random().Next(1, 100000),
                    FirstName = "Tural",
                    LastName = "Aliyev"
                }
            };
        public ContactDTO GetContactById(int id)
        {
            return AllContacts.FirstOrDefault(x => x.Id == id); 
        }

        public List<ContactDTO> GetAll()
        {
            return AllContacts;
        }

        public void Add(ContactDTO contact)
        {
            AllContacts.Add(contact);
        }

        public void Delete(int id)
        {
            var contact = AllContacts.FirstOrDefault(x => x.Id == id);
            if (contact != null)
            {
                AllContacts.Remove(contact);
            }
        }
    }
}
