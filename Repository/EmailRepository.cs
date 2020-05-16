using Microsoft.EntityFrameworkCore;
using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository;
using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository
{
    public class EmailRepository : IEmailRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public EmailRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }

        public async Task<Email> AddEmail(Email pn)
        {
            var result = await peopleDbContext.Emails.AddAsync(pn);
            await peopleDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteEmail(int id)
        {

            var result = await peopleDbContext.Emails
                                              .FirstOrDefaultAsync(e => e.EmailId == id);
            if (result != null)
            {
                peopleDbContext.Emails.Remove(result);
                await peopleDbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Email>> GetEmails(int id)
        {
            return await peopleDbContext.Emails.ToListAsync();
        }

        public async Task<Email> UpdateEmail(Email pn)
        {
            var result = await peopleDbContext.Emails.FirstOrDefaultAsync(e => e.EmailId == pn.EmailId);

            if (result != null)
            {
                result.MainEmail = pn.MainEmail;
                await peopleDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
