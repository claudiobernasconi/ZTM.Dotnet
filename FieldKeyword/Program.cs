public class Person
{
    // Auto Property: Property with implicit backing field
    public string Name { get; set; }

    // Property with explicit backing field
    private string _name2;
    public string Name2
    {
        get
        {
            return _name2;
        }
        set
        {
            _name2 = value;
        }
    }

    // Property with accessible implicit backing field
    public string Name3
    {
        get { return field; }
        set { field = value; }
    }

    // Property with accesible implicit backing field and logic
    public int Age
    {
        get { return field; }
        set
        {
            if (value > 0)
            {
                field = value;
            }
            throw new InvalidOperationException("Age must contain a positive number.");
        }
    }
}