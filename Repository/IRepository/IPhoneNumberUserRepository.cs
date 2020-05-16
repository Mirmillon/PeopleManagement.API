using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository
{
    interface IPhoneNumberUserRepository
    {
        Task<IEnumerable<PhoneUser>> GetMobileUsers();
        Task<IEnumerable<PhoneUser>> GetMobileUser(int userId);
        Task<PhoneUser> AddMobileUser(PhoneUser mobileUser);
        Task<PhoneUser> UpdateMobileUser(PhoneUser mobileUser);
        void DeleteMobileUser(int userId, int mobileId);
    }
}
