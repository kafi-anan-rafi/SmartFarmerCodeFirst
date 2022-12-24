using DAL.EF.Model;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ServiceRepo : Repo, IRepo<Service, int, Service>
    {
        public Service Add(Service obj)
        {
            db.Services.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Service Delete(int id)
        {
            var dbobj = Get(id);
            if (dbobj != null)
            {
                db.Services.Remove(dbobj);
                if (db.SaveChanges() > 0)
                {
                    return dbobj;
                }
                return null;
            }
            return null;
        }

        public List<Service> Get()
        {
            return db.Services.ToList();
        }

        public Service Get(int id)
        {
            return db.Services.Find(id);
        }

        public Service Update(Service obj)
        {
            var dbco = Get(obj.Id);
            db.Entry(dbco).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
