using CNGFinder.Models;

public interface IOwerService
{
    Task<Owner> RegisterOwner(Owner owner);
    Task<Owner> LoginOwner(string email, string password);
}
