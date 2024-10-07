var employees = new List<Employee>
{
    new Employee("John", "Miller", "Development"),
    new Employee("Jack", "Stevens", "Sales"),
    new Employee("Maria", "Mc Allister", "Sales"),
    new Employee("Christopher", "Collum", "Project Management"),
    new Employee("Javier", "Alegro", "Development")
};

var selectedEmployees = from employee in employees
                        where employee.FirstName.StartsWith("J")
                        orderby employee.LastName
                        select employee;

foreach (var employee in selectedEmployees)
{
    Console.WriteLine($"{employee.FirstName} {employee.LastName}");
}

var employeesByDepartment = from employee in employees
                            group employee by employee.Department into groupedEmployees
                            orderby groupedEmployees.Key
                            select groupedEmployees;

foreach (var department in employeesByDepartment)
{
    Console.WriteLine($"Departement: {department.Key}");

    foreach (var employee in department)
    {
        Console.WriteLine($"  {employee.FirstName} {employee.LastName}");
    }
}

record Employee(string FirstName, string LastName, string Department);