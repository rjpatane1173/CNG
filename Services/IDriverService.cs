using CNGFinder.Models;

public interface IDriverService
{
    Task<Driver> RegisterDriver(Driver driver);
    Task<Driver> LoginDriver(string email, string password);
}
