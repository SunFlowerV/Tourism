using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Models;

namespace Tourism.Services
{
    public interface IAttendanceReport
    {
        IEnumerable<Tourist> GetTourists();
        IEnumerable<CountryVisit> GetAttendanceReport(int year, int touristId);
    }
}
