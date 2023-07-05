    Console.Write("Enter Maximum degree : ");
    double MaximumDegree = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter The Number Of Students : ");
    int NumberOfStudents = Convert.ToInt32(Console.ReadLine()); ;
    int num = 1;
    object[,] School = new object[NumberOfStudents, 3];
while (num <= NumberOfStudents)
{
    Student ObjectStudent = new Student();
    try
    {
        
        Console.Write($"Enter Name {num} : ");
        ObjectStudent.Name = Console.ReadLine();
        Console.Write($"Enter Birthdate {num}: ");
        ObjectStudent.birthdate =Convert.ToDateTime(Console.ReadLine());
        Console.Write($"Enter degree {num} : ");
        ObjectStudent.degree = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Name : " + ObjectStudent.Name);
        Console.WriteLine($"Birthdate : {ObjectStudent.birthdate}");
       
        Console.WriteLine(ObjectStudent.Age);
        if (ObjectStudent.degree <= MaximumDegree && ObjectStudent.degree >= MaximumDegree / 2)
        {
            Console.WriteLine($"Degree : {ObjectStudent.degree}");
            Console.WriteLine("Succeded");
        }
        else if (ObjectStudent.degree > MaximumDegree || ObjectStudent.degree < 0)
        {
            Console.WriteLine("Wrong input");
        }
        else
        {
            Console.WriteLine($"Degree : {ObjectStudent.degree}");
            Console.WriteLine("Failed");
        }


        num++;

    }
    catch
    {
        Console.WriteLine("Erorr");
    }
    for (int i = 0; i < NumberOfStudents; i++)
    {
        Console.WriteLine($"Name: {ObjectStudent.Name}, Birthdate: {ObjectStudent.birthdate}, Degree: {ObjectStudent.degree}, Age: {ObjectStudent.Age}");
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
                Console.WriteLine($"Name: {ObjectStudent.Name}, Birthdate: {ObjectStudent.birthdate}, Degree: {ObjectStudent.degree}");
            }
        }
        if (!foundStudent)
        {
            Console.WriteLine("No students found.");
        }
    }
}