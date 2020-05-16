using Microsoft.EntityFrameworkCore;
using PeopleManagement.Models;
using PeopleManagement.Models.EnumTable;




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
            modelBuilder.Entity<PhoneNumber>().ToTable("TD_PhoneNumber");
            modelBuilder.Entity<Email>().ToTable("TD_Email");
            //TABLE JOINTURE
            // modelBuilder.Entity<MobileUser>().ToTable("TJ_MobileUser");
            //TABLE REFERENCE
            modelBuilder.Entity<Country>().ToTable("TR_Country");
            // modelBuilder.Entity<TelephoneNumberFormat>().ToTable("TR_TelephoneNumberFormat");
            //TABLE ENUM
            modelBuilder.Entity<Confidentiality>().ToTable("TRE_Confidentiality");
            modelBuilder.Entity<Gender>().ToTable("TRE_Gender");
            modelBuilder.Entity<NumberKind>().ToTable("TRE_NumberKind");
            modelBuilder.Entity<Device>().ToTable("TRE_Device");
            modelBuilder.Entity<Use>().ToTable("TRE_Use");
        }

        //TABLE DATA
        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Email> Emails { get; set; }

        //TABLE JOINTURE
        //public DbSet<MobileUser> MobileUsers { get; set; }

        //TABLE REFERENCE
        public DbSet<Country> Countries { get; set; }
        //public DbSet<TelephoneNumberFormat> TelephoneNumberFormats { get; set; }
        
        //TABLE ENUM
        public DbSet<Confidentiality> Confidentialities { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<NumberKind> NumberKinds { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Use> Uses { get; set; }
    }
}
