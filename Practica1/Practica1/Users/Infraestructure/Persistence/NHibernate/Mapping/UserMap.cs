using FluentNHibernate.Mapping;
using Practica1.Users.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Users.Infraestructure.Persistence.NHibernate.Mapping
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id).Column("user_id");
            Map(x => x.FirstName).Column("first_name");
            Map(x => x.LastName).Column("last_name");
            Map(x => x.Phone).Column("phone");
            References(x => x.Company, "company_id");
        }
    }
}
