using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism.Models
{
    public class CountryVisit
    {
        public int Id { get; set; }
        [Required]
        public int TouristId { get; set; }
        public Tourist Tourist { get; set; }
        [Required]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        [Required]
        public DateTime Date { get; set; }

    }
}
