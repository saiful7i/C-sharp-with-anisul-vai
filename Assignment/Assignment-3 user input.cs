using System;
class Program
{
    public static void Main(string[] args)
    {
        string? studentName;
        int studentAge;
        double studentResult;
        bool isRegistered;

        Console.WriteLine("----Student Form----");
        Console.Write("Enter Your Full Name:");
        studentName = Console.ReadLine();

        Console.Write("Enter Your Age:");
        studentAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Your University Result:");
        studentResult = Convert.ToDouble(Console.ReadLine());

        Console.Write("Have you already Registered:");
        isRegistered = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("----Student Form----");
        Console.WriteLine("\n----OUTPUT----");

        Console.WriteLine("Name:"+ studentName);
        Console.WriteLine("Age: "+studentAge+"years old.");
        Console.WriteLine("Result: " + studentResult + " C.G.P.A");
        Console.WriteLine("Registreation:" + isRegistered);

    }

}
