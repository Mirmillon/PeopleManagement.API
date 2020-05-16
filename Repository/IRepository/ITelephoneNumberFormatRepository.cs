using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository
{
    interface ITelephoneNumberFormatRepository
    {
        Task<IEnumerable<TelephoneNumberFormat>> GetTelephoneNumberFormats();
        Task<IEnumerable<TelephoneNumberFormat>> GetTelephoneNumberFormatByCountry(string countryId);
        Task<TelephoneNumberFormat> AddTelephoneNumberFormat(TelephoneNumberFormat telephoneNumberFormat);
        Task<TelephoneNumberFormat> UpdateTelephoneNumberFormat(TelephoneNumberFormat telephoneNumberFormat);
        void DeleteTelephoneNumberFormat(int telephoneNumberFormatId);
    }
}
