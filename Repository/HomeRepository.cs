using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository;
using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository
{
    public class HomeRepository : IHomeRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public HomeRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }

        public Task<Home> AddHome(Home home)
        {
            throw new NotImplementedException();
        }

        public void DeleteHome(string homeId)
        {
            throw new NotImplementedException();
        }

        public Task<Home> GetHome(string homeId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Home>> GetHomes()
        {
            throw new NotImplementedException();
        }

        public Task<Home> UpdateHome(Home home)
        {
            throw new NotImplementedException();
        }
    }
}
