public class Person
{
    string name = "Gosho";
    int age = 18;

    public int Age
    {
        set { age = value; }
        get { return age; }
    }
    public string Name
    {
        set { name = value; }
        get { return name; }
    }

    public Person()
    {
        Age = 1;
        Name = "No name";
    }

    public Person(int age)
    { this.Age = age; Name = "No name"; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
