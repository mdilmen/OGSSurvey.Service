using Microsoft.EntityFrameworkCore;
using OGSSurvey.Service.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGSSurvey.Service.Data
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }
        public DbSet<AgeRange> AgeRanges { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Premium> Premiums { get; set; }
        public DbSet<SurveyUser> SurveyUsers { get; set; }
        public DbSet<SubUser> SubUsers { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
