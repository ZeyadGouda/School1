Console.Write("Enter Maximum degree : ");
double MaximumDegree = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter The Number Of Students : ");
int NumberOfStudents = Convert.ToInt32(Console.ReadLine()); ;
int num = 1;
object[,] School = new object[NumberOfStudents, 3];
while (num <= NumberOfStudents)
{
    Console.Write($"Enter Name {num} : ");
    string name = Console.ReadLine();
    Console.Write($"Enter Birthdate {num}: ");
    DateTime birthdate = Convert.ToDateTime(Console.ReadLine());
    Console.Write($"Enter degree {num} : ");
    double degree = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Name : " + name);
    Console.WriteLine($"Birthdate : {birthdate}");
    TimeSpan a = DateTime.Now.Subtract(birthdate);
    DateTime s = DateTime.MinValue + a;
    string age = $"{s.Year - 1} Years {s.Month - 1} months {s.Day - 1} days";
    Console.WriteLine(age);
    if (degree <= MaximumDegree && degree >= MaximumDegree / 2)
    {
        Console.WriteLine($"Degree : {degree}");
        Console.WriteLine("Succeded");
    }
    else if (degree > MaximumDegree || degree < 0)
    {
        Console.WriteLine("Wrong input");
    }
    else
    {
        Console.WriteLine($"Degree : {degree}");
        Console.WriteLine("Failed");
    }

    School[num - 1, 0] = name;
    School[num - 1, 1] = birthdate;
    School[num - 1, 2] = degree;

    num++;
}
for (int i = 0; i < NumberOfStudents; i++)
{
    Console.WriteLine($"Name: {School[i, 0]}, Birthdate: {School[i, 1]}, Degree: {School[i, 2]}");
}
string searchName;
while (true)
{
    Console.Write("Search : ");
    searchName = Console.ReadLine();

    if (searchName == "")
        break;

    bool foundStudent = false;

    for (int i = 0; i < NumberOfStudents; i++)
    {
        if (((string)School[i, 0]).Contains(searchName))
        {
            foundStudent = true;
            Console.WriteLine($"Name: {School[i, 0]}, Birthdate: {School[i, 1]}, Degree: {School[i, 2]}");
        }
    }

    if (!foundStudent)
        Console.WriteLine("No students found.");
}

Console.ReadLine();