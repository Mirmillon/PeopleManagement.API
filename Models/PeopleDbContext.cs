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

            //TABLE DATA
            modelBuilder.Entity<Person>().ToTable("TD_Person");
            modelBuilder.Entity<Mobile>().ToTable("TD_Mobile");          
            //TABLE JOINTURE
            modelBuilder.Entity<MobileUser>().ToTable("TJ_MobileUser");
            //TABLE REFERENCE
            modelBuilder.Entity<Country>().ToTable("TR_Country");
            modelBuilder.Entity<TelephoneNumberFormat>().ToTable("TR_TelephoneNumberFormat");


        }

        //TABLE DATA
        public DbSet<Person> Persons { get; set; }
        public DbSet<Mobile> Mobiles { get; set; }
        //TABLE JOINTURE
        public DbSet<MobileUser> MobileUsers { get; set; }
        //TABLE REFERENCE
        public DbSet<Country> Countries { get; set; }
        public DbSet<TelephoneNumberFormat> TelephoneNumberFormats { get; set; }
    }
}
