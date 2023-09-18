int N = Convert.ToInt32(Console.ReadLine());
List<Car> list = new List<Car>(2);
for (int i = 0; i < N; i++)
{
    string[] info = Console.ReadLine().Split(" ");
    Car car = new Car(model: info[0], fuelAmount: Convert.ToDouble(info[1]), fuelConsumption: Convert.ToDouble(info[2]));
    list.Add(car);
}

string command = Console.ReadLine();
string[] drive = new string[3];
while (command.Equals("End"))
{
    drive = command.Split(" ");
    if
    (!list.Find(x => x.Model.Equals(drive[1])).CanDrive(Convert.ToDouble(drive[2])))
    { Console.WriteLine("Insufficient fuel for the drive"); }
    
}

foreach (Car car in list)
{
    Console.WriteLine(car.getCarInfo());
}