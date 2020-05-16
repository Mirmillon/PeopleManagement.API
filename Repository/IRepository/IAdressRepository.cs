using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository
{
    public interface IAdressRepository
    {
        Task<IEnumerable<Adress>> GetAdresses();
        Task<Adress> GetAdress(int id);
        Task<Adress> AddAdress(Adress Adress);
        Task<Adress> UpdateAdress(Adress Adress);
        void DeleteAdress(int id);
    }
}
