using System;
class Program
{
    public static void Main(string[] args)
    {
        int number;

        Console.Write("Please Enter a Number:");
        number = Convert.ToInt32(Console.ReadLine());

        if ( number % 2 == 0)
        {
            Console.WriteLine($"{number} is a EVEN Number");
        }
        else
        {
            Console.WriteLine($"{number} is a ODD Number");
        }
    }

}
