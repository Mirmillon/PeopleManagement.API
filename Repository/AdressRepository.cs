using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository;
using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository
{
    public class AdressRepository : IAdressRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public AdressRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }

        public Task<Adress> AddAdress(Adress Adress)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdress(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Adress> GetAdress(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Adress>> GetAdresses()
        {
            throw new NotImplementedException();
        }

        public Task<Adress> UpdateAdress(Adress Adress)
        {
            throw new NotImplementedException();
        }
    }
}
