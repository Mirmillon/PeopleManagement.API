using Microsoft.EntityFrameworkCore;
using PeopleManagement.Models;
using PeopleManagement.Models.EnumTable;
using PeopleManagement.Models.EnumTable.People;
using PeopleManagement.Models.Telecommunications;

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
            modelBuilder.Entity<Adress>().ToTable("TD_Adress");
            modelBuilder.Entity<Home>().ToTable("TD_Home");


            //TABLE JOINTURE

            //TelephoneNumberFormats
            modelBuilder.Entity<TelephoneNumberFormat>()
            .HasKey(t => new { t.CountryId, t.NumberKindId });

            modelBuilder.Entity<TelephoneNumberFormat>()
                .HasOne(pt => pt.Country)
                .WithMany(p => p.TelephoneNumberFormats)
                .HasForeignKey(pt => pt.CountryId);

            modelBuilder.Entity<TelephoneNumberFormat>()
                .HasOne(pt => pt.NumberKind)
                .WithMany(t => t.TelephoneNumberFormats)
                .HasForeignKey(pt => pt.NumberKindId);

            modelBuilder.Entity<TelephoneNumberFormat>().ToTable("TJ_TelephoneNumberFormat");
            //PhoneUsers
            modelBuilder.Entity<PhoneUser>()
           .HasKey(t => new { t.PersonId, t.PhoneNumberId });

            modelBuilder.Entity<PhoneUser>()
                .HasOne(pt => pt.Person)
                .WithMany(p => p.PhoneUsers)
                .HasForeignKey(pt => pt.PersonId);

            modelBuilder.Entity<PhoneUser>()
                .HasOne(pt => pt.PhoneNumber)
                .WithMany(t => t.PhoneUsers)
                .HasForeignKey(pt => pt.PhoneNumberId);

            modelBuilder.Entity<PhoneUser>().ToTable("TJ_PhoneUser");

            //HomeCountry
            modelBuilder.Entity<HomeCountry>().ToTable("TJ_HomeCountry");

            modelBuilder.Entity<HomeCountry>()
           .HasKey(t => new { t.CountryId, t.HomeId });

            modelBuilder.Entity<HomeCountry>()
                .HasOne(pt => pt.Country)
                .WithMany(p => p.HomeCountries)
                .HasForeignKey(pt => pt.CountryId);

            modelBuilder.Entity<HomeCountry>()
                .HasOne(pt => pt.Home)
                .WithMany(t => t.HomeCountries)
                .HasForeignKey(pt => pt.HomeId);

            //LanguagePerson
            modelBuilder.Entity<LanguagePerson>().ToTable("TJ_LanguagePerson");

            modelBuilder.Entity<LanguagePerson>()
           .HasKey(t => new { t.PersonId, t.LanguageId });

            modelBuilder.Entity<LanguagePerson>()
                .HasOne(pt => pt.Person)
                .WithMany(p => p.LanguagePersons)
                .HasForeignKey(pt => pt.PersonId);

            modelBuilder.Entity<LanguagePerson>()
                .HasOne(pt => pt.Language)
                .WithMany(t => t.LanguagePersons)
                .HasForeignKey(pt => pt.LanguageId);

            //LanguageCountry
            modelBuilder.Entity<LanguageCountry>().ToTable("TJ_LanguageCountry");


            modelBuilder.Entity<LanguageCountry>()
           .HasKey(t => new { t.CountryId, t.LanguageId });

            modelBuilder.Entity<LanguageCountry>()
                .HasOne(pt => pt.Country)
                .WithMany(p => p.LanguageCountries)
                .HasForeignKey(pt => pt.CountryId);

            modelBuilder.Entity<LanguageCountry>()
                .HasOne(pt => pt.Language)
                .WithMany(t => t.LanguageCountries)
                .HasForeignKey(pt => pt.LanguageId);


            //TABLE REFERENCE
            modelBuilder.Entity<Country>().ToTable("TR_Country");
            // modelBuilder.Entity<TelephoneNumberFormat>().ToTable("TR_TelephoneNumberFormat");
            //TABLE ENUM 
            modelBuilder.Entity<AdressKind>().ToTable("TRE_AdressKind");
            modelBuilder.Entity<Confidentiality>().ToTable("TRE_Confidentiality");
            modelBuilder.Entity<Gender>().ToTable("TRE_Gender");
            modelBuilder.Entity<NumberKind>().ToTable("TRE_NumberKind");
            modelBuilder.Entity<Device>().ToTable("TRE_Device");
            modelBuilder.Entity<Use>().ToTable("TRE_Use");
            modelBuilder.Entity<Language>().ToTable("TRE_Language");
            modelBuilder.Entity<LanguageLevel>().ToTable("TRE_LanguageLevel");
        } 

        //TABLE DATA
        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Email> Emails { get; set; }

        public DbSet<Adress> Adresses { get; set; }

        public DbSet<Home> Homes { get; set; }


        //TABLE JOINTURE
        public DbSet<PhoneUser> PhoneUsers { get; set; }
        public DbSet<TelephoneNumberFormat> TelephoneNumberFormats { get; set; }



        //TABLE REFERENCE
        public DbSet<Country> Countries { get; set; }
       
        
        //TABLE ENUM
        public DbSet<Confidentiality> Confidentialities { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<NumberKind> NumberKinds { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Use> Uses { get; set; }
        public DbSet<AdressKind> AdressKinds { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LanguageLevel> LanguageLevels { get; set; }
    }
}
