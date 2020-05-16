using PeopleManagement.Models.EnumTable.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable
{
    public interface IAdressKindRepository
    {
        Task<IEnumerable<AdressKind>> GetAdressKinds();
        Task<AdressKind> AddAdressKind(AdressKind a);
        Task<AdressKind> UpdateAdressKind(AdressKind a);
        void DeleteAdressKind(int id);
    }
}
