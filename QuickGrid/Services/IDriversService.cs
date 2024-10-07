namespace QuickGrid.Service;

public interface IDriversService
{
    IEnumerable<Driver> GetDrivers();
}

public record Driver(string Name, string Country, string Team, DateOnly DateOfBirth);
