using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository;
using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository
{
    public class LanguagePersonRepository : ILanguagePersonRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public LanguagePersonRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }

        public Task<LanguagePerson> AddLanguagePerson(LanguagePerson LanguagePerson)
        {
            throw new NotImplementedException();
        }

        public void DeleteLanguagePerson(LanguagePerson LanguagePerson)
        {
            throw new NotImplementedException();
        }

        public Task<LanguagePerson> GetLanguagePerson(int personId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LanguagePerson>> GetLanguagePersones()
        {
            throw new NotImplementedException();
        }

        public Task<LanguagePerson> GetPersonLanguage(int languageId)
        {
            throw new NotImplementedException();
        }

        public Task<LanguagePerson> UpdateLanguagePerson(LanguagePerson LanguagePerson)
        {
            throw new NotImplementedException();
        }
    }
}
