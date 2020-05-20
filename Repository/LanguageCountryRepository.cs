using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository;
using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository
{
    public class LanguageCountryRepository : ILanguageCountryRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public LanguageCountryRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }

        public Task<LanguageCountry> AddLanguageCountry(LanguageCountry LanguageCountry)
        {
            throw new NotImplementedException();
        }

        public void DeleteLanguageCountry(LanguageCountry LanguageCountry)
        {
            throw new NotImplementedException();
        }

        public Task<LanguageCountry> GetLanguageCountry(int countryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LanguageCountry>> GetLanguageCountryes()
        {
            throw new NotImplementedException();
        }

        public Task<LanguageCountry> GetPersonLanguage(int languageId)
        {
            throw new NotImplementedException();
        }

        public Task<LanguageCountry> UpdateLanguageCountry(LanguageCountry LanguageCountry)
        {
            throw new NotImplementedException();
        }
    }
}
