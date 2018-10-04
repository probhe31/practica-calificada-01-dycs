using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Users.Application.Dto
{
    public class UserCreateDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CompanyId { get; set; }

        public UserCreateDto()
        {

        }
    }
}
