using System;
class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("===== Cricle Area Calculator =====");

        double area, radius; 


        Console.Write("Enter the radius of Circle:");
        radius = Convert.ToDouble(Console.ReadLine());

        


        Console.WriteLine($"Circle Area = 3.1416 * {radius}^2 ");

        area = 3.1416 * (radius*radius);

        Console.WriteLine($"Result: {area}");


    }

}
