using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository
{
    public interface IHomeCountryRepository
    {
        Task<IEnumerable<HomeCountry>> GetHomeCountries();
        Task<HomeCountry> GetHomeCountry(int homeId);
        Task<HomeCountry> AddHomeCountry(HomeCountry homeCountry);
        Task<HomeCountry> UpdateHomeCountry(HomeCountry homeCountry);
        void DeleteHomeCountry(int homeId);
    }
}
