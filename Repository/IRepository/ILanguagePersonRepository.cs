using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository
{
    public interface ILanguagePersonRepository
    {
        Task<IEnumerable<LanguagePerson>> GetLanguagePersones();
        Task<LanguagePerson> GetLanguagePerson(int personId);
        Task<LanguagePerson> GetPersonLanguage(int languageId);
        Task<LanguagePerson> AddLanguagePerson(LanguagePerson LanguagePerson);
        Task<LanguagePerson> UpdateLanguagePerson(LanguagePerson LanguagePerson);
        void DeleteLanguagePerson(LanguagePerson LanguagePerson);
    }
}
