using System;

namespace DDD.Domain.Interfaces
{
    public interface IUnitOfWork2 : IDisposable
    {
        bool SaveChanges();
    }

  
}