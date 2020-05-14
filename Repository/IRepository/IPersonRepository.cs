using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetPersons();
        Task<Person> GetPerson(int personId);
        Task<Person> AddPerson(Person person);
        Task<Person> UpdatePerson(Person person);
        void DeletePerson(int personId);
    }
}
