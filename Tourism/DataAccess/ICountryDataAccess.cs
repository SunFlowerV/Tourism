using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Models;

namespace Tourism.DataAccess
{
    public interface ICountryDataAccess
    {
        IEnumerable<Country> GetCountries();
    }
}
