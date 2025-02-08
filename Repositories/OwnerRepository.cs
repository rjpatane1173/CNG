using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CNGFinder.Data;
using CNGFinder.Models;
using Microsoft.EntityFrameworkCore;

namespace CNGFinder.Repositories
{
    public class OwnerRepository : IRepository<Owner>
    {
        private readonly ApplicationDbContext _context;

        public OwnerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Retrieve all owners
        public async Task<IEnumerable<Owner>> GetAll()
        {
            return await _context.Owners.ToListAsync();
        }

        // Retrieve an owner by their ID
        public async Task<Owner> GetById(int id)
        {
            return await _context.Owners.FindAsync(id);
        }

        // Create a new owner
        public async Task<Owner> Create(Owner owner)
        {
            _context.Owners.Add(owner);
            await _context.SaveChangesAsync();
            return owner;
        }

        // Update an existing owner's details
        public async Task<Owner> Update(Owner owner)
        {
            _context.Owners.Update(owner);
            await _context.SaveChangesAsync();
            return owner;
        }

        // Delete an owner by their ID
        public async Task Delete(int id)
        {
            var owner = await _context.Owners.FindAsync(id);
            if (owner != null)
            {
                _context.Owners.Remove(owner);
                await _context.SaveChangesAsync();
            }
        }
    }
}
