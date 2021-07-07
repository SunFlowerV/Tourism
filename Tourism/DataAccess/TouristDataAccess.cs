using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Models;

namespace Tourism.DataAccess
{
    public class TouristDataAccess : ITouristDataAccess
    {
        private TourismContext db;
        public TouristDataAccess(TourismContext tourismContext)
        {
            db = tourismContext;
        }

        public IEnumerable<Tourist> GetTourists()
        {
            return db.Tourists.ToList();
        }
    }
}
