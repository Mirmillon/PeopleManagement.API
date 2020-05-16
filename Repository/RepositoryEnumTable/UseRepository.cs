using Microsoft.EntityFrameworkCore;
using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable;
using PeopleManagement.Models.EnumTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.RepositoryEnumTable
{
    public class UseRepository : IUseRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public UseRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }
        public async Task<Use> AddUse(Use c)
        {
            var result = await peopleDbContext.Uses.AddAsync(c);
            await peopleDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteUse(int id)
        {
            var result = await peopleDbContext.Uses
                                            .FirstOrDefaultAsync(e => e.UseId == id);

            if (result != null)
            {
                peopleDbContext.Uses.Remove(result);
                await peopleDbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Use>> GetUses()
        {
            return await peopleDbContext.Uses.ToListAsync();
        }

        public async Task<Use> UpdateUse(Use c)
        {
            var result = await peopleDbContext.Uses
                                             .FirstOrDefaultAsync(e => e.UseId == c.UseId);

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
