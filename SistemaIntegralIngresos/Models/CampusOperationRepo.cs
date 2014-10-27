using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;


namespace SistemaIntegralIngresos.Models
{
    public class CampusOperationRepo :ICampus
    {
        SIIDbContext _db = new SIIDbContext();
        public List<Campus> GetAllCampus()
        {
           //ToDO: add Repository Data
            return null;
        }


        public bool InsertCampus(Campus campus)
        {
            if(campus != null )
                using(_db)
            {
                _db.Campus.Add(campus);
                _db.SaveChanges();
                return true;
            }
            throw new ArithmeticException();
        }


        public bool DeleteCampus(int id)
        {
            Campus campus = _db.Campus.Find(id);
            if (campus.Name != null)
            using (_db)    
            {
                _db.Campus.Remove(campus);
                _db.SaveChanges();
                return true;
            }
            throw new NotImplementedException();
        }

        public Campus FindByID(int id)
        {
            Campus campus = _db.Campus.Find(id);
            if ( campus.Name != null)
            using (_db)
            {
                return campus;
            }
                  throw new NotImplementedException();        
        }

        public bool EditCampus(Campus campus)
        {           
            if (campus.Name != null )
            {
                _db.Entry(campus).State = EntityState.Modified;
                _db.SaveChanges();
                return true;
            }          
            throw new NotImplementedException();
        }
    }
}