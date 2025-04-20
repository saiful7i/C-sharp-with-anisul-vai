using System;
using System.Threading.Channels;
class Program
{
   
    public static void Main(string[] args)
    {
        Console.Write("Enter start number:"); 
        int startNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter end number:");
        int endNumber = Convert.ToInt32(Console.ReadLine());

        for (int i = startNumber; i <= endNumber; i++)
        {
            Console.WriteLine($"Multiplication of {i}");
            for (int j =1; j <= 10; j++)
            {
                Console.WriteLine($"{i} * {j} = {i*j}");
            }
            Console.WriteLine("---------------------");
            
            
        }

    }

}
