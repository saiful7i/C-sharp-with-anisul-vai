using System;
using System.Threading.Channels;
class Program
{
   
    public static void Main(string[] args)
    {
        Console.Write("Factorial Number:");
        int factorial = Convert.ToInt32(Console.ReadLine());

        
        int fact = 1;

        for (int i= factorial; 1<=i; i--)
        {
            fact = fact * i; 

        }
        Console.WriteLine($"{factorial} factorial Number is :{fact}");

    }

}
