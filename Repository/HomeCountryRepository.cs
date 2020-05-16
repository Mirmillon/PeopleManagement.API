using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository;
using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository
{
    public class HomeCountryRepository : IHomeCountryRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public HomeCountryRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }

        public Task<HomeCountry> AddHomeCountry(HomeCountry homeCountry)
        {
            throw new NotImplementedException();
        }

        public void DeleteHomeCountry(int homeId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HomeCountry>> GetHomeCountries()
        {
            throw new NotImplementedException();
        }

        public Task<HomeCountry> GetHomeCountry(int homeId)
        {
            throw new NotImplementedException();
        }

        public Task<HomeCountry> UpdateHomeCountry(HomeCountry homeCountry)
        {
            throw new NotImplementedException();
        }
    }
}
