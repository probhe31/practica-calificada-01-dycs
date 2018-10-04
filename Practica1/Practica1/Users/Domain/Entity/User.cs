using Practica1.Companies.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Users.Domain.Entity
{
    public class User
    {

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Company Company { get; set; }

        public User()
        {

        }
    }
}
