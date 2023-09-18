
class Task1to4
{
    private static void Main()
    {
        Person pesho = new Person("pesho", 20);
        

        Person gosho = new Person();

        Person stamat = new Person("Stamat", 43);
        Console.WriteLine("task 1 and 2");
       
        Console.WriteLine("name: {0}; age: {1}", pesho.Name, pesho.Age);
        Console.WriteLine("name: {0}; age: {1}", gosho.Name, gosho.Age);
        Console.WriteLine("name: {0}; age: {1}", stamat.Name, stamat.Age);
        

        Console.WriteLine("task 3");

        Console.WriteLine("quantity of people:");

        int quantity3 = Convert.ToInt32(Console.ReadLine());
        Family Members = new Family();

        Console.WriteLine("input the names and ages of family members");
        for (int i = 0; i < quantity3; i++)
        {
            Console.WriteLine("name:");
            string name = Console.ReadLine();
            Console.WriteLine("age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Person member = new Person(name, age);
            Members.AddMember(member);
        }

        Console.WriteLine(Members.GetOldestMember().Name+", "+ Members.GetOldestMember().Age);

        Console.WriteLine("task 4");
        Console.WriteLine("quantity of people:");

        int quantity4 = Console.Read();

        List<Person> persons = new List<Person>(quantity4);

        Console.WriteLine("input the names and ages of family members");
        for (int i = 0; i < quantity4; i++)
        {
            Console.WriteLine("name:");
            string name = Console.ReadLine();
            Console.WriteLine("age:");
            int age = Console.Read();
            Person member = new Person(name, age);
            persons.Add(member);
        }
        persons.OrderBy(x => x.Name);
        foreach (Person person in persons)
        {
            if (person.Age > 30)
            { Console.WriteLine(person.Name+", "+person.Age); }
        }
    }


}