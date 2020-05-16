using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable;
using PeopleManagement.Models.EnumTable.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.RepositoryEnumTable
{
    public class AdressKindRepository : IAdressKindRepository
    {

        private readonly PeopleDbContext peopleDbContext;

        public AdressKindRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }

        public Task<AdressKind> AddAdressKind(AdressKind a)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdressKind(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AdressKind>> GetAdressKinds()
        {
            throw new NotImplementedException();
        }

        public Task<AdressKind> UpdateAdressKind(AdressKind a)
        {
            throw new NotImplementedException();
        }
    }
}
