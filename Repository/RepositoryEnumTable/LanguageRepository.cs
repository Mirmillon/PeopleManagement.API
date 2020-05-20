using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable;
using PeopleManagement.Models.EnumTable.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.RepositoryEnumTable
{
    public class LanguageRepository : ILanguageRepository
    {

        private readonly PeopleDbContext peopleDbContext;

        public LanguageRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }


        public Task<Language> AddLanguage(Language c)
        {
            throw new NotImplementedException();
        }

        public void DeleteLanguage(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Language>> GetLanguages()
        {
            throw new NotImplementedException();
        }

        public Task<Language> UpdateLanguage(Language c)
        {
            throw new NotImplementedException();
        }
    }
}
