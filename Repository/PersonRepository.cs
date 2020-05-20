using Microsoft.EntityFrameworkCore;
using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository;
using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository
{
    public class PersonRepository : IPersonRepository
    {

        private readonly PeopleDbContext peopleDbContext;

        public PersonRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }

        public async Task<Person> AddPerson(Person person)
        {
            var result = await peopleDbContext.Persons.AddAsync(person);
            await peopleDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Person> DeletePerson(int personId)
        {
            var result = await peopleDbContext.Persons
                                             .FirstOrDefaultAsync(e => e.PersonId == personId);
            if (result != null)
            {
                peopleDbContext.Persons.Remove(result);
                await peopleDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async  Task<Person> GetPerson(int personId)
        {
          
           return await peopleDbContext.Persons.FirstOrDefaultAsync(e => e.PersonId == personId);
        }

        public async  Task<IEnumerable<Person>> GetPersons()
        {
           
            return await peopleDbContext.Persons.ToListAsync();
        }

        public async Task<Person> UpdatePerson(Person person)
        {
            var result = await peopleDbContext.Persons
                                             .FirstOrDefaultAsync(e => e.PersonId == person.PersonId);

            if (result != null)
            {

                result.FirstName = person.FirstName;
                result.MiddleName = person.MiddleName;
                result.LastName = person.LastName;
                result.DateOfBirth = person.DateOfBirth;
                result.Alive = person.Alive;
                //result.Gender = person.Gender;
                result.DateOfDead = person.DateOfDead;


                await peopleDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
