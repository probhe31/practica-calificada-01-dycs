using Practica1.Projects.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Projects.Domain.Repository
{
    public interface IProjectRepository
    {
        void Create(Project project);
        void Delete(Project project);
        Project Read(long id);
    }
}
