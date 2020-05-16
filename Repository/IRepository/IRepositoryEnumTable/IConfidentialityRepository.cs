using PeopleManagement.Models.EnumTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable
{
    interface IConfidentialityRepository
    {
        Task<IEnumerable<Confidentiality>> GetConfidentialities();

        Task<Confidentiality> GetConfidentiality(int id);
        Task<Confidentiality> AddConfidentiality(Confidentiality c);
        Task<Confidentiality> UpdateConfidentiality(Confidentiality c);
        void DeleteConfidentiality(int id);
    }
}
