using System.Drawing;
using System.Reflection;

int num_engines = Convert.ToInt32(Console.ReadLine());
List<Engine> engines = new List<Engine>(num_engines);

for (int i=0; i < num_engines; i++)
{
    string[] info = Console.ReadLine().Split(" ");
    if (!(info[2].Any(char.IsDigit) && (info[3] is null) ))
    {
        info[3] = info[2];
        info[2] = null;
    }

    Engine engine = new Engine(model: info[0], power: Convert.ToInt16(info[1]), displacement: info[2], efficiency: info[4]);
    engines.Add(engine);
}

int num_cars = Convert.ToInt32(Console.ReadLine());
List<Car> cars = new List<Car>(num_cars);
for (int i=0;i < num_cars; i++)
{
    string[] info = Console.ReadLine().Split(" ");
    if (!(info[2].Any(char.IsDigit) && (info[3] is null)))
    {
        info[3] = info[2];
        info[2] = null;
    }

    Engine engine = engines.Find(x => x.model.Equals(info[1]));

    Car car = new Car(model: info[0], engine: engine, weight: info[2], color: info[3]);
    cars.Add(car);
}


