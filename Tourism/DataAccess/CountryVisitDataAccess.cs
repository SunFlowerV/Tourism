using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Models;

namespace Tourism.DataAccess
{
    public class CountryVisitDataAccess : ICountryVisitDataAccess
    {
        private TourismContext db;
        public CountryVisitDataAccess(TourismContext tourismContext)
        {
            db = tourismContext;
        }
        public IEnumerable<CountryVisit> GetCountryVisits()
        {
            return db.CountryVisits.Include(u => u.Country).Include(p => p.Tourist).ToList();
        }

        public IEnumerable<CountryVisit> GetCountryVisits(int year, int touristId)
        {
            return db.CountryVisits.Include(u => u.Country).Include(p => p.Tourist).Where(y => y.TouristId == touristId).Where(d => d.Date.Year == year).ToList();
        }
    }
}
