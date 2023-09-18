
class Family
{
    List<Person> Members
    { get; set; }

    public void AddMember(Person member)
    {
        Members.Add(member);
    }
    public Person GetOldestMember()
    {
        Person oldest = new Person(0);
        foreach (Person member in Members)
        {
            if (member.Age > oldest.Age)
            { oldest = member; }
        }
        return oldest;
    }

}
