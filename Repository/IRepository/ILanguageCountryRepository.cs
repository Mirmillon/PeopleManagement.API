using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository
{
    public interface  ILanguageCountryRepository
    {
        Task<IEnumerable<LanguageCountry>> GetLanguageCountryes();
        Task<LanguageCountry> GetLanguageCountry(int countryId);
        Task<LanguageCountry> GetPersonLanguage(int languageId);
        Task<LanguageCountry> AddLanguageCountry(LanguageCountry LanguageCountry);
        Task<LanguageCountry> UpdateLanguageCountry(LanguageCountry LanguageCountry);
        void DeleteLanguageCountry(LanguageCountry LanguageCountry);
    }
}
