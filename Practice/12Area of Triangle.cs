using System;
class Program
{
    public static void Main(string[] args)
    {
        // triangle  area = 0.5 * base * hight

        Console.WriteLine("===== Triangle Area Calculator =====");

        double triangleBase, hight , area; 


        Console.Write("Enter the base of Triangle:");
        triangleBase = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Hight of Triangle:");
        hight = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine($"Triangle Area = 0.5 * {triangleBase} * {hight} ");

        area = 0.5 * triangleBase * hight;

        Console.WriteLine($"Result: {area}");


    }

}
