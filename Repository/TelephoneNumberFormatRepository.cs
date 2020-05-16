using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository;
using PeopleManagement.Models.Telecommunications;

namespace PeopleManagement.API.Repository
{
    public class TelephoneNumberFormatRepository : ITelephoneNumberFormatRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public TelephoneNumberFormatRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }

        public Task<TelephoneNumberFormat> AddTelephoneNumberFormat(TelephoneNumberFormat telephoneNumberFormat)
        {
            throw new NotImplementedException();
        }

        public void DeleteTelephoneNumberFormat(int telephoneNumberFormatId)
        {
            throw new NotImplementedException();
        }

        public  Task<IEnumerable<TelephoneNumberFormat>> GetTelephoneNumberFormatByCountry(string code)
        {
            throw new NotImplementedException();
        }

      
        public Task<IEnumerable<TelephoneNumberFormat>> GetTelephoneNumberFormats()
        {
            throw new NotImplementedException();
            //return await peopleDbContext.TelephoneNumberFormats.ToListAsync();
        }

        public Task<TelephoneNumberFormat> UpdateTelephoneNumberFormat(TelephoneNumberFormat telephoneNumberFormat)
        {
            throw new NotImplementedException();
        }
    }
}
