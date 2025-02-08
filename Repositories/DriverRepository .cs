using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CNGFinder.Data;
using CNGFinder.Models;
using Microsoft.EntityFrameworkCore;

namespace CNGFinder.Repositories
{
    public class DriverRepository : IRepository<Driver>
    {
        private readonly ApplicationDbContext _context;

        public DriverRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Driver>> GetAll()
        {
            return await _context.Drivers.ToListAsync();
        }

        public async Task<Driver> GetById(int id)
        {
            return await _context.Drivers.FindAsync(id);
        }

        public async Task<Driver> Create(Driver driver)
        {
            _context.Drivers.Add(driver);
            await _context.SaveChangesAsync();
            return driver;
        }

        public async Task<Driver> Update(Driver driver)
        {
            _context.Drivers.Update(driver);
            await _context.SaveChangesAsync();
            return driver;
        }

        public async Task Delete(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);
            if (driver != null)
            {
                _context.Drivers.Remove(driver);
                await _context.SaveChangesAsync();
            }
        }
    }
}
