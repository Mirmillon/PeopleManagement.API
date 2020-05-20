using Microsoft.AspNetCore.Mvc;
using PeopleManagement.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Controller
{
    public class LanguegePersonController :ControllerBase
    {
        private readonly PeopleDbContext peopleDbContext;

        public LanguegePersonController(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }
    }
}
