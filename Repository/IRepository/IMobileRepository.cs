using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository
{
    interface IMobileRepository
    {
        Task<IEnumerable<Mobile>> GetMobiles();
        Task<Mobile> GetMobile(int mobileId);
        Task<Mobile> AddMobile(Mobile mobile);
        Task<Mobile> UpdateMobile(Mobile mobile);
        void DeleteMobile(int mobileId);
    }
}
