using Practica1.Common.Infraestructure.Persistence.NHibernate;
using Practica1.Projects.Domain.Entity;
using Practica1.Projects.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Projects.Infraestructure.Persistence.NHibernate.Repository
{
    public class ProjectNHibernateRepository : BaseNHibernateRepository<Project>, IProjectRepository
    {
        public ProjectNHibernateRepository(UnitOfWorkNHibernate unitOfWork) : base(unitOfWork)
        {

        }
    }
}
