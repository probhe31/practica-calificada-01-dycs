using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Companies.Application.Dto
{
    public class CompanyCreateDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public CompanyCreateDto()
        {

        } 
    }
}
