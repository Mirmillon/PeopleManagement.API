using PeopleManagement.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Controller.ControllerEnumTable
{
    public class DeviceController
    {
        private readonly PeopleDbContext peopleDbContext;

        public DeviceController(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }
    }
}
