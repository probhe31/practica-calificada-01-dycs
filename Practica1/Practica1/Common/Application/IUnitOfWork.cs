using System.Data;


namespace Practica1.Common.Application
{
    public interface IUnitOfWork
    {
        bool BeginTransaction(IsolationLevel isolationLevel);
        void Commit(bool commit);
        void Rollback(bool rollback);
    }
}
