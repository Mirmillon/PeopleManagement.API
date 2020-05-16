using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository
{
    interface IPhoneNumberRepository
    {

        Task<IEnumerable<PhoneNumber>> GetPhoneNumbers(int personId);
        Task<PhoneNumber> GetPhoneNumber(int pnId);
        Task<PhoneNumber> AddPhoneNumber(PhoneNumber pn);
        Task<PhoneNumber> UpdatePhoneNumber(PhoneNumber pn);
        void DeletePhoneNumber(int pnId);
    }
}
