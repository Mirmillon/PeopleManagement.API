using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository
{
    interface IEmailRepository
    {
        Task<IEnumerable<Email>> GetEmails(int id);
        Task<Email> AddEmail(Email pn);
        Task<Email> UpdateEmail(Email pn);
        void DeleteEmail(int id);
    }
}
