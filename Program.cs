double MaximumDegree = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter The Number Of Students : ");
int NumberOfStudents = Convert.ToInt32(Console.ReadLine()); ;
int num = 1;
School MySchool = new School();
Student ObjectStudent;

while (num <= NumberOfStudents)
{
    ObjectStudent = new Student();
    try
    {
        Console.Write($"Enter Name {num} : ");
        ObjectStudent.Name = Console.ReadLine();
        Console.Write($"Enter Birthdate {num}: ");
        ObjectStudent.birthdate = Convert.ToDateTime(Console.ReadLine());
        Console.Write($"Enter degree {num} : ");
        ObjectStudent.degree = Convert.ToDouble(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("ERROR");
    }
        if
            (ObjectStudent.degree > MaximumDegree || ObjectStudent.degree < 0)
        {
            Console.WriteLine("Wrong input");
        }
        
        MySchool.Students.Add(ObjectStudent);

        num++;
 

        Console.WriteLine($"Name: {ObjectStudent.Name}, Birthdate: {ObjectStudent.birthdate}, Degree: {ObjectStudent.degree}, Age: {ObjectStudent.Age}");
    string searchName;
    while (true)
    {
        Console.Write("Search : ");
        searchName = Console.ReadLine();

        if (searchName == "")
            break;

        bool foundStudent = false;

        foreach (Student student in MySchool.Students)
        {
            if (student.Name == searchName)
                {
                foundStudent = true;
                Console.WriteLine($"Name: {ObjectStudent.Name}, Birthdate: {ObjectStudent.birthdate}, Degree: {ObjectStudent.degree}, Age: {ObjectStudent.Age}");
            }
        }
        if (!foundStudent)
        {
            Console.WriteLine("No students found.");
        }
    }
}
foreach (Student student in MySchool.Students)
{
    Console.WriteLine($"Name: {student.Name}, Birthdate: {student.birthdate}, Degree: {student.degree}, Age: {student.Age}");
}