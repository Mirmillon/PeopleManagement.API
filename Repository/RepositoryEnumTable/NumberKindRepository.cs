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
    public class NumberKindRepository : INumberKindRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public NumberKindRepository (PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }

        public async Task<NumberKind> AddNumberKind(NumberKind c)
        {
            var result = await peopleDbContext.NumberKinds.AddAsync(c);
            await peopleDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteNumberKind(int id)
        {
            var result = await peopleDbContext.NumberKinds
                                          .FirstOrDefaultAsync(e => e.NumberKindId == id);

            if (result != null)
            {
                peopleDbContext.NumberKinds.Remove(result);
                await peopleDbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<NumberKind>> GetNumberKinds()
        {
            return await peopleDbContext.NumberKinds.ToListAsync();
        }

        public async Task<NumberKind> UpdateNumberKind(NumberKind c)
        {
            var result = await peopleDbContext.NumberKinds
                                              .FirstOrDefaultAsync(e => e.NumberKindId == c.NumberKindId);

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
