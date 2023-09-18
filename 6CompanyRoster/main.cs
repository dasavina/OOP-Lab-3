int N = Convert.ToInt32( Console.ReadLine());
List<Employee> employees =  new List<Employee>(N);
for (int i = 0; i<N; i++)
{
    Console.WriteLine("input information in this order: name, salary, position, department, email and age.");
    string[] info = new string[6];
    info = (Console.ReadLine()).Split(" ");

    Employee employee = new Employee(info[0], Convert.ToDouble(info[1]), info[2], info[3]); 
    employee.Email = info[4];
   employee.Age = Convert.ToInt32(info[5]);

    employees.Add(employee);
}

employees.OrderBy(x => x.Department);
double average = employees[0].Salary;
double MaxAverage = 0;
string BestDepartment = employees[0].Department;
for (int i = 1;i < employees.Count;i++)
{
    if (employees[i].Department.Equals(employees[i - 1].Department))
    {
        average = (average + employees[i].Salary) / 2;
    }
    else 
    { 
        BestDepartment = (average > MaxAverage) ? employees[i-1].Department : BestDepartment;
        MaxAverage = (average > MaxAverage) ? average : MaxAverage; 
    }
}

Console.WriteLine("Highest Average Salary: " + BestDepartment);

foreach (Employee employee in employees)
{
    if (employee.Department.Equals(BestDepartment))
    { Console.WriteLine(employee.getEmployee()); }
}
