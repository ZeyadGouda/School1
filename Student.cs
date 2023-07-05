public class Student
{
    public string Name { get; set; }
    public double degree;
    public DateTime birthdate;
    private decimal age;
    public decimal Age
    {
        get
        {
            TimeSpan a = DateTime.Now.Subtract(birthdate);
            DateTime s = DateTime.MinValue + a;
            age = s.Year - 1;
            return age;
        }
    }
}