using System;
class Program
{
    public static void Main(string[] args)
    {
        string? studentName;
        int studentAge;


        Console.Write("Enter Your Name:");
        studentName = Console.ReadLine();

        Console.Write("Enter Your Age:");
        studentAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Name:"+ studentName);
        Console.WriteLine("Age: "+studentAge+"years old.");

    }

}
