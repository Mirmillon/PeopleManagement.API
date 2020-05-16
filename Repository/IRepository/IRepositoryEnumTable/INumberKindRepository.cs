using PeopleManagement.Models.EnumTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable
{
   interface INumberKindRepository
   {
        Task<IEnumerable<NumberKind>> GetNumberKinds();
        Task<NumberKind> AddNumberKind(NumberKind c);
        Task<NumberKind> UpdateNumberKind(NumberKind c);
        void DeleteNumberKind(int id);
   }
}
