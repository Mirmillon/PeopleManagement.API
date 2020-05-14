using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository
{
    interface IMobileUserRepository
    {
        Task<IEnumerable<MobileUser>> GetMobileUsers();
        Task<IEnumerable<MobileUser>> GetMobileUser(int userId);
        Task<MobileUser> AddMobileUser(MobileUser mobileUser);
        Task<MobileUser> UpdateMobileUser(MobileUser mobileUser);
        void DeleteMobileUser(int userId, int mobileId);
    }
}
