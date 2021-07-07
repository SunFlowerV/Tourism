using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Models;
using Tourism.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tourism.Controllers
{
    [Route("api/report")]
    [ApiController]
    public class AttendanceReportController : ControllerBase
    {
        private IAttendanceReport attendanceReport;
        public AttendanceReportController(IAttendanceReport _attendanceReport)
        {
            attendanceReport = _attendanceReport;
        }
        // GET: api/<AttendanceReport>
        [HttpGet]
        public IEnumerable<Tourist> GetTouristList()
        {
            return attendanceReport.GetTourists();
        }

        // GET api/<AttendanceReport>/5
        [HttpGet("{touristid}/{year}")]
        public IEnumerable<CountryVisit> Get(int touristId, int year)
        {
            return attendanceReport.GetAttendanceReport(year, touristId);
        }

        
    }
}
