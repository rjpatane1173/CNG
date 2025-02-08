using System;
using System.Linq;
using System.Threading.Tasks;
using CNGFinder.Models;
using CNGFinder.Repositories;

namespace CNGFinder.Services
{
    public class OwnerService :IOwerService
    {
        private readonly IRepository<Owner> _repository;

        public OwnerService(IRepository<Owner> repository)
        {
            _repository = repository;
        }

        // Register a new owner
        public async Task<Owner> RegisterOwner(Owner owner)
        {
            var existingOwners = await _repository.GetAll();
            if (existingOwners.Any(o => o.Email == owner.Email))
                throw new Exception("Owner with this email already exists");

            return await _repository.Create(owner);
        }

        // Login an existing owner
        public async Task<Owner> LoginOwner(string email, string password)
        {
            var owners = await _repository.GetAll();
            var owner = owners.FirstOrDefault(o => o.Email == email);

            if (owner == null || owner.Password != password)
                throw new Exception("Invalid credentials");

            return owner;
        }
    }
}
