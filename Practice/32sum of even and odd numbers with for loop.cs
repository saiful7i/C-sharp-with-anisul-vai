using System;
using System.Threading.Channels;
class Program
{
   
    public static void Main(string[] args)
    {
        Console.Write("First number of series:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Last number of series:");
        int lastNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Difference between number of series:");
        int differenceNumber = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int n=firstNumber; n<=lastNumber; n=n+differenceNumber)
        {
            if ( n % 2 == 0)
            {
                sum = sum + n;
            }

        }
        Console.WriteLine($"{sum}");

    }

}
