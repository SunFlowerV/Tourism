using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism.Models
{
    public class Tourist
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        public List<CountryVisit> CountryVisits { get; set; }
        public Tourist()
        {
            CountryVisits = new List<CountryVisit>();
        }
    }
}
