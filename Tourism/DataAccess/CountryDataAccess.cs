using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Models;

namespace Tourism.DataAccess
{
    public class CountryDataAccess : ICountryDataAccess
    {
        private TourismContext db;
        public CountryDataAccess(TourismContext tourismContext)
        {
            db = tourismContext;
        }
        public IEnumerable<Country> GetCountries()
        {
            return db.Countries.ToList();
        }
    }
}
