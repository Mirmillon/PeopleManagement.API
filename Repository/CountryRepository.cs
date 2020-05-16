using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository;
using PeopleManagement.Models;

namespace PeopleManagement.API.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public CountryRepository (PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }
        public async Task<Country> AddCountry(Country country)
        {
            var result = await peopleDbContext.Countries.AddAsync(country);
            await peopleDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteCountry(string countryId)
        {
            var result = await peopleDbContext.Countries
                                              .FirstOrDefaultAsync(e => e.CountryId == countryId);
            if (result != null)
            {
                peopleDbContext.Countries.Remove(result);
                await peopleDbContext.SaveChangesAsync();
            }
        }

       

        public async Task<Country> GetCountry(string countryId)
        {
            return await peopleDbContext.Countries.FirstOrDefaultAsync(e => e.CountryId == countryId);
        }

     
        public async Task<IEnumerable<Country>> GetCountrys()
        {
            return await peopleDbContext.Countries.ToListAsync();
        }

        public async Task<Country> UpdateCountry(Country country)
        {
            var result = await peopleDbContext.Countries
                                        .FirstOrDefaultAsync(e => e.CountryId == country.CountryId);

            if (result != null)
            {
        
                result.CodeISO156A3 = country.CodeISO156A3;
                result.CodeISO156C = country.CodeISO156C;
                result.NameCountry = country.NameCountry;
                result.PathFlag = country.PathFlag;
                result.TelephonePrefix = country.TelephonePrefix;
               

                await peopleDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
