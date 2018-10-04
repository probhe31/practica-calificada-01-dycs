using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Companies.Domain.Entity
{
    public class Company
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Phone { get; set; }

        public Company()
        {

        }
    }
}
