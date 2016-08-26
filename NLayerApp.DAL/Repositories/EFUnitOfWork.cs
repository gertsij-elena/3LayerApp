using System;
using NLayerApp.DAL.EF;
using NLayerApp.DAL.Interfaces;
using NLayerApp.DAL.Entities;
//using System.Data.Entity;

namespace NLayerApp.DAL.Repositories
{
    public class EFUnitOfWork : IDisposable, IUnitOfWork
    {
        private HotelContext db;
        private NumberRepository numberRepository;
        private OrderRepository orderRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new HotelContext(connectionString);
        }
        public IRepository<Number> Numbers
        {
            get
            {
                if (numberRepository == null)
                    numberRepository = new NumberRepository(db);
                return numberRepository;
            } 
        }

        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
