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


    }

class Program
{
    private static void Main()
    {
        Person pesho = new Person();
        pesho.Age = 20;
        pesho.Name = "Pesho";

        Person gosho = new Person();
       
        Person stamat = new Person();
        stamat.Age = 43;
        stamat.Name = "Stamat";

        Console.WriteLine("name: {0}; age: {1}", pesho.Name, pesho.Age) ;
        Console.WriteLine("name: {0}; age: {1}", gosho.Name, gosho.Age) ;
        Console.WriteLine("name: {0}; age: {1}", stamat.Name, stamat.Age) ;
    }
}