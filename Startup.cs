using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PeopleManagement.API.Models;
using PeopleManagement.API.Repository;
using PeopleManagement.API.Repository.IRepository;
using PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable;
using PeopleManagement.API.Repository.RepositoryEnumTable;
using PeopleManagement.Models.EnumTable.People;

namespace PeopleManagement.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PeopleDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PeopleConnection")));
            services.AddControllers();
            //IREPOSITORY
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IPhoneNumberRepository, PhoneNumberRepository>();
            services.AddScoped<IEmailRepository, EmailRepository>();
            services.AddScoped<IHomeRepository, HomeRepository>();
            services.AddScoped<IAdressRepository, AdressRepository>();
            services.AddScoped<IHomeCountryRepository, HomeCountryRepository>();
            services.AddScoped<ILanguageCountryRepository, LanguageCountryRepository>();
            services.AddScoped<ILanguagePersonRepository, LanguagePersonRepository>();
            //IREPOSITORY TRE
            services.AddScoped<IConfidentialityRepository, ConfidentialityRepository>();
            services.AddScoped<IUseRepository, UseRepository>();
            services.AddScoped<IDeviceRepository, DeviceRepository>();
            services.AddScoped<IGenderRepository, GenderRepository>();
            services.AddScoped<INumberKindRepository, NumberKindRepository>();
            services.AddScoped<IAdressKindRepository, AdressKindRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
