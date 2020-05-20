using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleManagement.API.Repository.IRepository;
using PeopleManagement.Models;
using System;
using System.Threading.Tasks;

namespace PeopleManagement.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetPersons()
        {
            try
            {
                return Ok(await personRepository.GetPersons());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error retrieving data from the database"); ;
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Person>> GetPerson(int id)
        {
            try
            {
                var result = await personRepository.GetPerson(id);

                if (result == null) return NotFound();

                return result;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error retrieving data from the database"); ;
            }
        }

        [HttpPost]
        public async Task<ActionResult<Person>> CreatePerson(Person person)
        {
            try
            {
                if (person == null)
                    return BadRequest();

                var createdPerson = await personRepository.AddPerson(person);

                return CreatedAtAction(nameof(GetPerson),
                    new { id = createdPerson.PersonId }, createdPerson);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Person>> UpdatePerson(int id, Person person)
        {
            try
            {
                if (id != person.PersonId)
                    return BadRequest("Person ID mismatch");

                var personToUpdate = await personRepository.GetPerson(id);

                if (personToUpdate == null)
                    return NotFound($"Person with Id = {id} not found");

                return await personRepository.UpdatePerson(person);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Person>> DeletePerson(int id)
        {
            try
            {
                var personToDelete = await personRepository.GetPerson(id);

                if (personToDelete == null)
                {
                    return NotFound($"Person with Id = {id} not found");
                }

                return await personRepository.DeletePerson(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }
    }
}
