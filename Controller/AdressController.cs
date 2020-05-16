using Microsoft.AspNetCore.Mvc;
using PeopleManagement.API.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Controller
{
    public class AdressController :ControllerBase
    {
        private readonly IAdressRepository adressRepository;

        public AdressController(IAdressRepository adressRepository)
        {
            this.adressRepository = adressRepository;
        }
    }
}
