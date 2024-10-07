namespace QuickGrid.Service;

public class DriversService : IDriversService
{
    public IEnumerable<Driver> GetDrivers()
    {
        return new List<Driver>
        {
            new Driver("Max Verstappen", "Netherlands", "Red Bull Racing", new DateOnly(1997, 9, 30)),
            new Driver("Sergio Perez", "Mexico", "Red Bull Racing", new DateOnly(1990, 1, 26)),
            new Driver("Lewis Hamilton", "United Kingdom", "Mercedes", new DateOnly(1985, 1, 7)),
            new Driver("George Russell", "United Kingdom", "Mercedes", new DateOnly(1998, 2, 15)),
            new Driver("Charles Leclerc", "Monaco", "Ferrari", new DateOnly(1997, 10, 16)),
            new Driver("Carlos Sainz", "Spain", "Ferrari", new DateOnly(1994, 9, 1)),
            new Driver("Lando Norris", "United Kingdom", "McLaren", new DateOnly(1999, 11, 13)),
            new Driver("Oscar Piastri", "Australia", "McLaren", new DateOnly(2001, 4, 6)),
            new Driver("Fernando Alonso", "Spain", "Aston Martin", new DateOnly(1981, 7, 29)),
            new Driver("Lance Stroll", "Canada", "Aston Martin", new DateOnly(1998, 10, 29)),
            new Driver("Pierre Gasly", "France", "Alpine", new DateOnly(1996, 2, 7)),
            new Driver("Esteban Ocon", "France", "Alpine", new DateOnly(1996, 9, 17)),
            new Driver("Alex Albon", "Thailand", "Williams", new DateOnly(1996, 3, 23)),
            new Driver("Logan Sargeant", "United States", "Williams", new DateOnly(2000, 12, 31)),
            new Driver("Valtteri Bottas", "Finland", "Sauber", new DateOnly(1989, 8, 28)),
            new Driver("Zhou Guanyu", "China", "Sauber", new DateOnly(1999, 5, 30)),
            new Driver("Kevin Magnussen", "Denmark", "Haas", new DateOnly(1992, 10, 5)),
            new Driver("Nico Hulkenberg", "Germany", "Haas", new DateOnly(1987, 8, 19)),
            new Driver("Daniel Ricciardo", "Australia", "AlphaTauri", new DateOnly(1989, 7, 1)),
            new Driver("Yuki Tsunoda", "Japan", "AlphaTauri", new DateOnly(2000, 5, 11))
        };
    }
}
