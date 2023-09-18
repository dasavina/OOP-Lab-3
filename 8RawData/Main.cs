// “<Model> <EngineSpeed> <EnginePower> <CargoWeight><CargoType> <Tire1Pressure> <Tire1Age>
// <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age><Tire4Pressure> <Tire4Age>” 

int N = Convert.ToInt32(Console.ReadLine());
List<Car> list = new List<Car>(2);
for (int i = 0; i < N; i++)
{
   string[] carProperties = Console.ReadLine().Split(" ");

}