using FluentNHibernate.Mapping;
using Practica1.Projects.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Projects.Infraestructure.Persistence.NHibernate.Mapping
{
    public class ProjectMap : ClassMap<Project>
    {
        public ProjectMap()
        {
            Id(x => x.Id).Column("project_id");
            Map(x => x.Name).Column("name");
            Component(x => x.Budget, m =>
            {
                m.Map(x => x.Amount, "budget");
                m.Map(x => x.Currency, "currency");
            });
            References(x => x.Company, "company_id");

        }
        
    }
}
