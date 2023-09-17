
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
