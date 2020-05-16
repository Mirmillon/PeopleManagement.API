using PeopleManagement.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Controller.ControllerEnumTable
{
    public class NumberKindController
    {
        private readonly PeopleDbContext peopleDbContext;

        public NumberKindController(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }
    }
}
