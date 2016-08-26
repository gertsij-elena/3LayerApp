using System;
using System.Collections.Generic;
using System.Linq;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.EF;
using NLayerApp.DAL.Interfaces;
using System.Data.Entity;

namespace NLayerApp.DAL.Repositories
{
    public class NumberRepository : IRepository<Number>
    {
        private HotelContext db;

        public NumberRepository(HotelContext context)
        {
            this.db = context;
        }

        public IEnumerable<Number> GetAll()
        {
            return db.Numbers;
        }

        public Number Get(int id)
        {
            return db.Numbers.Find(id);
        }

        public void Create(Number book)
        {
            db.Numbers.Add(book);
        }

        public void Update(Number book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<Number> Find(Func<Number, Boolean> predicate)
        {
            return db.Numbers.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Number book = db.Numbers.Find(id);
            if (book != null)
                db.Numbers.Remove(book);
        }
    }
}
