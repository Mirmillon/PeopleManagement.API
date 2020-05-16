using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Home>> GetHomes();
        Task<Home> GetHome(string homeId);
        Task<Home> AddHome(Home home);
        Task<Home> UpdateHome(Home home);
        void DeleteHome(string homeId);
    }
}
