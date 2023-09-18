Console.WriteLine("fist date:");
string date1 = Console.ReadLine();
Console.WriteLine("second date:");
string date2 = Console.ReadLine();
DateModifier dateModifier = new DateModifier();
dateModifier.CalculateDifference(date1, date2);
Console.WriteLine(dateModifier.Difference);
