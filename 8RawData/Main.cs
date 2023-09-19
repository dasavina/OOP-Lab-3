// “<Model> <EngineSpeed> <EnginePower> <CargoWeight><CargoType> <Tire1Pressure> <Tire1Age>
// <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age><Tire4Pressure> <Tire4Age>” 

int N = Convert.ToInt32(Console.ReadLine());
List<Car> list = new List<Car>(2);
for (int i = 0; i < N; i++)
{
   string[] carProperties = Console.ReadLine().Split(" ");
    Engine engine = new Engine(engineSpeed: Convert.ToInt32(carProperties[1]), enginePower: Convert.ToInt32(carProperties[2]));
    Cargo cargo = new Cargo(cargoWeight: Convert.ToInt32(carProperties[3]), cargoType: carProperties[4] );
    List<Tire> tires = new List<Tire>(4)
    {
        new Tire(Convert.ToInt32(carProperties[5]), Convert.ToInt32(carProperties[6])),
        new Tire(Convert.ToInt32(carProperties[7]), Convert.ToInt32(carProperties[8])),
        new Tire(Convert.ToInt32(carProperties[9]), Convert.ToInt32(carProperties[10])),
        new Tire(Convert.ToInt32(carProperties[11]), Convert.ToInt32(carProperties[12]))
    };
    Car car = new Car(model: carProperties[0], engine, cargo, tires);
    list.Add(car);
}

string command = Console.ReadLine();
switch (command)
{
    case "fragile":
        {
            foreach(Car car in list)
            {
                car.isFragile();
            }

        }break;
    case "flamable":
        {
            foreach (Car car in list)
            {
                car.isFlamable();
            }

        } break;
    default: Console.WriteLine("wrong command"); break;
}