using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism.Models
{
    public class TourismContext : DbContext
    {
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryVisit> CountryVisits { get; set; }

        public TourismContext(DbContextOptions<TourismContext> options) : base(options)
        {

        }
    }
}
