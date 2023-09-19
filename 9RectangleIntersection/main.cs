string[] numbers = Console.ReadLine().Split();

List<Rectangle> rectangles = new List<Rectangle>(Convert.ToInt32(numbers[0]));

for (int i = 0; i < Convert.ToInt32(numbers[0]); i++)
{
    string[] info = Console.ReadLine().Split();
    Rectangle rectangle = new Rectangle(info[0], Convert.ToInt32(info[1]), Convert.ToInt32(info[2]), Convert.ToInt32(info[3]), Convert.ToInt32(info[4]));
    rectangles.Add(rectangle);
}

List<string[]> pairs = new List<string[]>(Convert.ToInt32(numbers[1]));
for (int i = 0;i < Convert.ToInt32(numbers[1]); i++)
{
   pairs.Add(Console.ReadLine().Split(" "));
}

for (int i = 0;i<pairs.Count() ; i++)
{
    Console.WriteLine(rectangles.Find(x => x.id.Equals(pairs[i][0])).Intersects(rectangles.Find(x => x.id.Equals(pairs[i][1]))));

}

