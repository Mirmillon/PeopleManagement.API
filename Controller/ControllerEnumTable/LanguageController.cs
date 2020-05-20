using Microsoft.AspNetCore.Mvc;
using PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Controller.ControllerEnumTable
{
    public class LanguageController :ControllerBase
    {
        private readonly ILanguageRepository languageRepository;
        public LanguageController(ILanguageRepository languageRepository)
        {
            this.languageRepository = languageRepository;
        }
    }
}
