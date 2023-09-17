class Family
{
    List<Person> members = new List<Person>();

    void AddMember(Person member)
    {
        members.Add(member);
    }
    Person GetOldestMember()
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

        Console.WriteLine("input the names and ages of family members")

    }
}