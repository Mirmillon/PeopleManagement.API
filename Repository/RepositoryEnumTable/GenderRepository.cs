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
    public class GenderRepository : IGenderRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public GenderRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }

        async Task<Gender> IGenderRepository.AddGender(Gender c)
        {
            var result = await peopleDbContext.Genders.AddAsync(c);
            await peopleDbContext.SaveChangesAsync();
            return result.Entity;
        }

        async void IGenderRepository.DeleteGender(int id)
        {

            var result = await peopleDbContext.Genders.FirstOrDefaultAsync(e => e.GenderId == id);

            if (result != null)
            {
                peopleDbContext.Genders.Remove(result);
                await peopleDbContext.SaveChangesAsync();
            }
        }

        async Task<Gender> IGenderRepository.GetGender(int id)
        {
            return await peopleDbContext.Genders.FirstOrDefaultAsync(e => e.GenderId == id);
        }

        public async Task<IEnumerable<Gender>> GetGenders()
        {
            return await peopleDbContext.Genders.ToListAsync();
        }

        async Task<Gender> IGenderRepository.UpdateGender(Gender c)
        {
            var result = await peopleDbContext.Genders
                                               .FirstOrDefaultAsync(e => e.GenderId == c.GenderId);

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
