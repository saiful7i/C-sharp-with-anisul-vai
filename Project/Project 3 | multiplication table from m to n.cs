using System;
using System.Threading.Channels;
class Program
{
   
    public static void Main(string[] args)
    {
        Console.Write("Enter any number:"); 
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }

    }

}
