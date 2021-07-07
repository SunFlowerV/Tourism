using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.DataAccess;
using Tourism.Models;

namespace Tourism.Services
{
    public class CountryList : ICountryList
    {
        private ICountryDataAccess data;
        public CountryList(ICountryDataAccess countryDataAccess)
        {
            data = countryDataAccess;
        }
        public IEnumerable<Country> GetCountries()
        {
            return data.GetCountries();
        }
    }
}
