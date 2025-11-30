using System;

public class Program
{
    public static void Main(string[] args)
    {
        Student s = new Student();
        Console.WriteLine("    Default  ");
        Console.WriteLine("Person: " + s.Info.ToString());
        Console.WriteLine("Education: " + s.Edu);
        Console.WriteLine("Group: " + s.Group);
        
        s.Info = new Person("Борис", "Хлебович", new DateTime(2000, 10, 29));
        s.Edu = Education.Specialist;
        s.Group = 2;
        Console.WriteLine("    NEW    ");
        Console.WriteLine("Person: " + s.Info.ToString());
        Console.WriteLine("Education: " + s.Edu);
        Console.WriteLine("Group: " + s.Group);
    }
}