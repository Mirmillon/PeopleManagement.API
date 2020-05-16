using Microsoft.EntityFrameworkCore;
using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable;
using PeopleManagement.Models.EnumTable;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.RepositoryEnumTable
{
    public class ConfidentialityRepository : IConfidentialityRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public ConfidentialityRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }
        public async Task<Confidentiality> AddConfidentiality(Confidentiality c)
        {
            var result = await peopleDbContext.Confidentialities.AddAsync(c);
            await peopleDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteConfidentiality(int id)
        {
            var result =  await peopleDbContext.Confidentialities
                                            .FirstOrDefaultAsync(e => e.ConfidentialityId == id);

            if (result != null)
            {
                peopleDbContext.Confidentialities.Remove(result);
                await peopleDbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Confidentiality>> GetConfidentialities()
        {
            return await peopleDbContext.Confidentialities.ToListAsync();
        }

        public async  Task<Confidentiality> GetConfidentiality(int id)
        {
           return  await peopleDbContext.Confidentialities
                                              .FirstOrDefaultAsync(e => e.ConfidentialityId == id);
        }

        public async Task<Confidentiality> UpdateConfidentiality(Confidentiality c)
        {
            var result = await peopleDbContext.Confidentialities
                                              .FirstOrDefaultAsync(e => e.ConfidentialityId == c.ConfidentialityId);

            if (result != null)
            {
                result.Label = c.Label;
                await peopleDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }
    }
}
