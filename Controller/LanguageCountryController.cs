using Microsoft.AspNetCore.Mvc;
using PeopleManagement.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Controller
{
    public class LanguageCountryController :ControllerBase
    {
        private readonly PeopleDbContext peopleDbContext;

        public LanguageCountryController(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }
    }
}
