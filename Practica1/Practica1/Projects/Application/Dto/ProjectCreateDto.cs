using Practica1.Common.Application.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Projects.Application.Dto
{
    public class ProjectCreateDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Decimal Budget { get; set; }
        public Currency Currency{ get; set; }
        public long CompanyId { get; set; }

        public ProjectCreateDto()
        {

        }



    }
}
