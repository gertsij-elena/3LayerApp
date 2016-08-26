using NLayerApp.DAL.Entities;
using System;

namespace NLayerApp.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Number> Numbers { get;}
        IRepository<Order> Orders { get;}
        void Save();
    }
}
