class Employee
{

    public int Age
    {
        get; set;
    }
    public double Salary
    {
        get { return Salary; }
        set { Salary = Math.Round(Salary, 2); }
    }
    public string Name
    { get; set; }
    public string Position
    { get; set; }
    public string Department
    { get; set; }
    public string Email
    {
        get { return Email; }
        set { Email = (value is null) ? "n/a" : value; }
    }

    public Employee(string name, double salary, string position, string department, string email, string age)
    {
        Age = (age is null)? -1: Convert.ToInt16(age);
        Salary = salary;
        Name = name;
        Position = position;
        Department = department;
        Email = email;
    }

    public string getEmployee()
    {
        return (Name + " " + Salary + " " + Position + " " + Department + " " + Email + " " + Age);
    }
}