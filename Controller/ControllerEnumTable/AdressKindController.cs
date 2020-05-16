using PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Controller.ControllerEnumTable
{
    public class AdressKindController
    {
        private readonly IAdressKindRepository adressKindRepository;
        public AdressKindController(IAdressKindRepository adressKindRepository)
        {
            this.adressKindRepository = adressKindRepository;
        }
    }
}
