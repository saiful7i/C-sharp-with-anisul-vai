using System;
using System.Threading.Channels;
class Program
{
    //Project-1 | temperature Converter
    public static void Main(string[] args)
    {
        Console.WriteLine("==========Temperature Converter Started==========");
        Console.WriteLine("Choose 1. To Convert Farhrenheit to Celsisus");
        Console.WriteLine("Choose 2. To Convert Celsisus to Fahrenheit");
        Console.Write("Please Enter 1 or 2:");

       // int choice = Convert.ToInt32(Console.ReadLine());
       if (int.TryParse(Console.ReadLine(),out int choice))
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Fahrenheit temperature:");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    double celsisus = (fahrenheit - 32) / 1.8;
                    Console.WriteLine($"Temperature in Celsisus:{celsisus:F2} degree");
                    break;
                case 2:
                    Console.Write("Enter Celsisus temperature:");
                    double cels = Convert.ToDouble(Console.ReadLine());
                    double fahren = cels * 1.8 + 32;
                    Console.WriteLine($"Temperature in Fahrenheit:{fahren:F2} degree");
                    break;
                default:
                    Console.WriteLine("Invalid Choose.");
                    break;
            }

        }
       else
        {
            Console.WriteLine("Invalid Choose.");
        }
       
        

    }

}
