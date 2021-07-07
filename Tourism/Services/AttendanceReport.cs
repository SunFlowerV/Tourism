using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.DataAccess;
using Tourism.Models;

namespace Tourism.Services
{
    public class AttendanceReport : IAttendanceReport
    {
        ITouristDataAccess touristData;
        ICountryVisitDataAccess visitData;
        public AttendanceReport(ITouristDataAccess touristDataAccess, ICountryVisitDataAccess countryVisitDataAccess)
        {
            touristData = touristDataAccess;
            visitData = countryVisitDataAccess;
        }
        public IEnumerable<CountryVisit> GetAttendanceReport(int year, int touristId)
        {
            return visitData.GetCountryVisits(year, touristId);
        }

        public IEnumerable<Tourist> GetTourists()
        {
            return touristData.GetTourists();
        }
    }
}
