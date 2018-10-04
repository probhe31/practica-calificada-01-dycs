using Practica1.Common.Infraestructure.Persistence.NHibernate;
using Practica1.Companies.Domain.Entity;
using Practica1.Companies.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Companies.Infraestructure.Persistence.NHibernate.Repository
{ 
    public class CompanyNHibernateRepository : BaseNHibernateRepository<Company>, ICompanyRepository
    {
        public CompanyNHibernateRepository(UnitOfWorkNHibernate unitOfWork) : base(unitOfWork)
        {

        }
    }
}
