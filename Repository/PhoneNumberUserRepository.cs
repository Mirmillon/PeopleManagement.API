using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository;
using PeopleManagement.Models;

namespace PeopleManagement.API.Repository
{
    public class PhoneNumberUserRepository : IPhoneNumberUserRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public PhoneNumberUserRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }
        public Task<PhoneUser> AddMobileUser(PhoneUser mobileUser)
        {
            throw new NotImplementedException();
        }

        public void DeleteMobileUser(int userId, int mobileId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PhoneUser>> GetMobileUser(int userId)
        {
            throw new NotImplementedException();
        }

        public  Task<IEnumerable<PhoneUser>> GetMobileUsers()
        {
            throw new NotImplementedException();
           // return await peopleDbContext.MobileUsers.ToListAsync();
        }

        public Task<PhoneUser> UpdateMobileUser(PhoneUser mobileUser)
        {
            throw new NotImplementedException();
        }
    }
}
