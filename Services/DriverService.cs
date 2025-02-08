using System;
using System.Linq;
using System.Threading.Tasks;
using CNGFinder.Models;
using CNGFinder.Repositories;

namespace CNGFinder.Services
{
    public class DriverService : IDriverService
    {
        private readonly IRepository<Driver> _repository;

        public DriverService(IRepository<Driver> repository)
        {
            _repository = repository;
        }

        public async Task<Driver> RegisterDriver(Driver driver)
        {
            var existingDrivers = await _repository.GetAll();
            if (existingDrivers.Any(d => d.Email == driver.Email))
                throw new Exception("Driver with this email already exists");

            return await _repository.Create(driver);
        }

        public async Task<Driver> LoginDriver(string email, string password)
        {
            var drivers = await _repository.GetAll();
            var driver = drivers.FirstOrDefault(d => d.Email == email);

            if (driver == null || driver.Password != password)
                throw new Exception("Invalid credentials");

            return driver;
        }
    }
}
