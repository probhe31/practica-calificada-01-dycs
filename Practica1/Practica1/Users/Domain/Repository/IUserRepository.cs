using Practica1.Users.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Users.Domain.Repository
{
    public interface IUserRepository
    {
        void Create(User bankAccount);
        void Delete(User bankAccount);
        User Read(long id);
    }
}
