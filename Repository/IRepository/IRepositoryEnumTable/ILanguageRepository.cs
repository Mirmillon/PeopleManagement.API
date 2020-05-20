using PeopleManagement.Models.EnumTable.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable
{
    public interface ILanguageRepository
    {
        Task<IEnumerable<Language>> GetLanguages();
        Task<Language> AddLanguage(Language c);
        Task<Language> UpdateLanguage(Language c);
        void DeleteLanguage(int id);
    }
}
