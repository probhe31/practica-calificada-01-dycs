using Practica1.Common.Domain.ValueObject;
using Practica1.Companies.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Projects.Domain.Entity
{
    public class Project
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Money Budget { get; set; }
        public virtual Company Company { get; set; }

        public Project()
        {

        }
    }
}
