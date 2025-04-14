using System;
class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("===== Cricle Area Calculator =====");

        double area, radis; 


        Console.Write("Enter the radis of Circle:");
        radis = Convert.ToDouble(Console.ReadLine());

        


        Console.WriteLine($"Circle Area = 3.1416 * {radis}^2 ");

        area = 3.1416 * (radis*radis);

        Console.WriteLine($"Result: {area}");


    }

}
