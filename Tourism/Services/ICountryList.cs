using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Models;

namespace Tourism.Services
{
    public interface ICountryList
    {
        IEnumerable<Country> GetCountries();
    }
}
