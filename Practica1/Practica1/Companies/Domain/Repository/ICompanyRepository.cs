using Practica1.Companies.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Companies.Domain.Repository
{
    public interface ICompanyRepository
    {
        void Create(Company company);
        void Delete(Company company);
        Company Read(long id);
    }
}
