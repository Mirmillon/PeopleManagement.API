using PeopleManagement.Models.EnumTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable
{
    interface IUseRepository
    {
        Task<IEnumerable<Use>> GetUses();
        Task<Use> AddUse(Use c);
        Task<Use> UpdateUse(Use c);
        void DeleteUse(int id);
    }
}
