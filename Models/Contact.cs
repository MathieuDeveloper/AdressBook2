using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdressBook2.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public DateTime Created { get; set; }

        public IFormFile ImageFile { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageType { get; set; }

        public int Id { get; set; }

        [NotMapped]
        public string FullName {  get { return $"{FirstName} {LastName}"; } }
    }
}
