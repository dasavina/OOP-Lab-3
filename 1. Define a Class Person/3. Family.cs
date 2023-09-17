class Family
{
    List<Person> members = new List<Person>();
    List<Person> Members
    { get; set; }

    public void AddMember(Person member)
    {
        members.Add(member);
    }
    public Person GetOldestMember()
    {
        Person oldest = new Person(0);
        foreach (Person member in members)
        {
            if (member.Age > oldest.Age)
            { oldest = member; }
        }
        return oldest;
    }

}

class Task2
{
    static public void Main()
    {
        Console.WriteLine("quantity of people:");

        int quantity = Console.Read();
        Family Members = new Family();

        Console.WriteLine("input the names and ages of family members");
        for (int i = 0; i < quantity; i++)
        {
            Console.WriteLine("name:");
            string name = Console.ReadLine();
            Console.WriteLine("age:");
            int age = Console.Read();
            Person member = new Person(name, age);
            Members.AddMember(member);
        }

        Console.WriteLine(Members.GetOldestMember());
    }
}