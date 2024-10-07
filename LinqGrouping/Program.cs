var employees = new List<Employee>
{
    new Employee("John", "Miller", "Development"),
    new Employee("Jack", "Stevens", "Sales"),
    new Employee("Maria", "Mc Allister", "Sales"),
    new Employee("Christopher", "Collum", "Project Management"),
    new Employee("Javier", "Alegro", "Development")
};

var personsByDepartment = employees.GroupBy(person => person.Department);

foreach (var department in personsByDepartment)
{
    Console.WriteLine($"Department: {department.Key}");

    foreach (var employee in department)
    {
        Console.WriteLine($"  {employee.FirstName} {employee.LastName}");
    }
}

record Employee(string FirstName, string LastName, string Department);