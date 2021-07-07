using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Models;
using Tourism.Services;

namespace Tourism.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        private ICountryList countryList;
        public IndexController(ICountryList _countryList)
        {
            countryList = _countryList;
        }
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return countryList.GetCountries();
        }
    }
}
