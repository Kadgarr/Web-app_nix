using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DL.Entities;
using DL.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DL.Repository
{
    public class SingerRepository : IRepository<Singer>
    {
        ApplicationContext db = new ApplicationContext();

        public void Add(Singer item)
        {
            db.Singers.Add(item);
        }

        public void Change(Singer item)
        {
            db.Attach(item).State = EntityState.Modified;
        }

        public void Delete(Singer item)
        {
            db.Singers.Remove(item);
        }

        public Singer GetItem(Guid item)
        {
            return db.Singers.Find(item);
        }

        public IEnumerable<Singer> GetList()
        {
            return db.Singers.ToList();
        }
    }
}
