using PeopleManagement.API.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Controller
{
    public class HomeCountryController
    {
        private readonly IHomeCountryRepository homeCountryRepository;

        public HomeCountryController(IHomeCountryRepository homeCountryRepository)
        {
            this.homeCountryRepository = homeCountryRepository;
        }
    }
}
