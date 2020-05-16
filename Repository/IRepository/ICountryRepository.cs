using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository
{
    interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetCountrys();
        Task<Country> GetCountry(string countryId);
        Task<Country> AddCountry(Country country);
        Task<Country> UpdateCountry(Country country);
        void DeleteCountry(string countryId);
    }
}
