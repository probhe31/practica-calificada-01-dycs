using Practica1.Common.Infraestructure.Persistence.NHibernate;
using Practica1.Users.Domain.Entity;
using Practica1.Users.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Users.Infraestructure.Persistence.NHibernate.Repository
{
    public class UserNHibernateRepository : BaseNHibernateRepository<User>, IUserRepository
    {
        public UserNHibernateRepository(UnitOfWorkNHibernate unitOfWork) : base(unitOfWork)
        {

        }
    }
}
