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
    public class PhoneNumberRepository : IPhoneNumberRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public PhoneNumberRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }

    

        public async Task<PhoneNumber> AddPhoneNumber(PhoneNumber pn)
        {
            var result = await peopleDbContext.PhoneNumbers.AddAsync(pn);
            await peopleDbContext.SaveChangesAsync();
            return result.Entity;
        }

      

        public async void DeletePhoneNumber(int pnId)
        {
            var result = await peopleDbContext.PhoneNumbers
                                            .FirstOrDefaultAsync(e => e.PhoneNumberId == pnId);
            if (result != null)
            {
                peopleDbContext.PhoneNumbers.Remove(result);
                await peopleDbContext.SaveChangesAsync();
            }
        }

        

        public async Task<PhoneNumber> GetPhoneNumber(int pnId)
        {
            return await peopleDbContext.PhoneNumbers.FirstOrDefaultAsync(e => e.PhoneNumberId == pnId);
        }

        public Task<IEnumerable<PhoneNumber>> GetPhoneNumbers(int personId)
        {
            throw new NotImplementedException();
        }

        public async Task<PhoneNumber> UpdatePhoneNumber(PhoneNumber pn)
        {
            var result = await peopleDbContext.PhoneNumbers
                                             .FirstOrDefaultAsync(e => e.PhoneNumberId == pn.PhoneNumberId);

            if (result != null)
            {

                result.Number = pn.Number;
                result.PersonId = pn.PersonId;
                //result.TelephoneNumberKind = pn.TelephoneNumberKind;
                result.ConfidentialityId = pn.ConfidentialityId;
                result.CountryId = pn.CountryId;
               
                await peopleDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
