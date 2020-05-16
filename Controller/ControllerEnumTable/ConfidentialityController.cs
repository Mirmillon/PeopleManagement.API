using Microsoft.AspNetCore.Mvc;
using PeopleManagement.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Controller.ControllerEnumTable
{
    public class ConfidentialityController : ControllerBase
    {
        private readonly PeopleDbContext peopleDbContext;

        public ConfidentialityController(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }
    }
}
