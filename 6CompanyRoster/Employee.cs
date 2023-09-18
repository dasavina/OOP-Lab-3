class Employee
{
       
    public int Age
    { get { return Age; }
        set { Age = (value is 0) ? -1 : value; }
    }
    public int Salary
    { get; set; }
    public string Name
    { get; set; }
    public string Position
    { get; set; }
    public string Department
    { get; set; }
    public string Email
    {  get { return Email; }
        set { Email = (value is null) ? "n/a" : value; }
    }

    public Employee(string name, int salary, string position, string department)
    {
        Salary = salary;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Position = position ?? throw new ArgumentNullException(nameof(position));
        Department = department ?? throw new ArgumentNullException(nameof(department));
    }

    public string getEmployee()
    {
        return (Name + " " + Salary + " " + Position + " " + Department + " " + Email + " " + Age);
    }
}