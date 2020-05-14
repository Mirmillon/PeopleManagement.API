using Microsoft.EntityFrameworkCore;
using PeopleManagement.Models;
using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Models
{
    public class PeopleDbContext :DbContext
    {
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Code to seed data
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Mobile> Mobiles { get; set; }
        public DbSet<Landline> Landlines { get; set; }
    }
}
