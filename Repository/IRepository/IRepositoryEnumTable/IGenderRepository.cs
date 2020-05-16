using PeopleManagement.Models.EnumTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable
{
    interface IGenderRepository
    {
        Task<IEnumerable<Gender>> GetGenders();

        Task<Gender> GetGender(int id);
        Task<Gender> AddGender(Gender c);
        Task<Gender> UpdateGender(Gender c);
        void DeleteGender(int id);
    }
}
