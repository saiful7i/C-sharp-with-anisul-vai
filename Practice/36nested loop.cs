using System;
using System.Threading.Channels;
class Program
{
   
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 3; i++) // inner loop
        {
            for (int j = 1; j <= 5; j++) //outer loop
            {
                Console.WriteLine($"{j} : Bangladesh");
            }
            Console.WriteLine();
        }


    }

}
