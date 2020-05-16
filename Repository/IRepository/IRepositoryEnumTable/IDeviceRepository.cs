using PeopleManagement.Models.EnumTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable
{
    interface IDeviceRepository
    {
        Task<IEnumerable<Device>> GetDevices();
        Task<Device> AddDevice(Device c);
        Task<Device> UpdateDevice(Device c);
        void DeleteDevice(int id);
    }
}
