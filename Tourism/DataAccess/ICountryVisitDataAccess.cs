using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Models;

namespace Tourism.DataAccess
{
    public interface ICountryVisitDataAccess
    {
        IEnumerable<CountryVisit> GetCountryVisits();
        IEnumerable<CountryVisit> GetCountryVisits(int year, int touristId);
    }
}
