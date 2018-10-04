using FluentNHibernate.Mapping;
using Practica1.Companies.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Companies.Infraestructure.Persistence.NHibernate.Mapping
{
    public class CompanyMap : ClassMap<Company>
    {
        public CompanyMap()
        {
            Id(x => x.Id).Column("company_id");
            Map(x => x.Name).Column("name");
            Map(x => x.Phone).Column("phone");

        }
    }
}
