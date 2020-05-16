using Microsoft.EntityFrameworkCore;
using PeopleManagement.API.Models;
using PeopleManagement.API.Repository.IRepository.IRepositoryEnumTable;
using PeopleManagement.Models.EnumTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.API.Repository.RepositoryEnumTable
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly PeopleDbContext peopleDbContext;

        public DeviceRepository(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }

        public async Task<Device> AddDevice(Device c)
        {
            var result = await peopleDbContext.Devices.AddAsync(c);
            await peopleDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteDevice(int id)
        {
            var result = await peopleDbContext.Devices
                                          .FirstOrDefaultAsync(e => e.DeviceId == id);

            if (result != null)
            {
                peopleDbContext.Devices.Remove(result);
                await peopleDbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Device>> GetDevices()
        {
            return await peopleDbContext.Devices.ToListAsync();
        }

        public async Task<Device> UpdateDevice(Device c)
        {
            var result = await peopleDbContext.Devices
                                             .FirstOrDefaultAsync(e => e.DeviceId == c.DeviceId);

            if (result != null)
            {
                result.Label = c.Label;
                await peopleDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }
    }
}
