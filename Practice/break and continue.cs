using System;
using System.Threading.Channels;
class Program
{
   
    public static void Main(string[] args)
    {
        // while loop
        int i = 1; // initializer

        while (i <= 100) //condition
        {
            if (i == 50)
            {
                 break;
                
            }
            Console.Write($" {i} ");
            i++; //update
        }

        for (int n = 1; n <= 100; n++) 
        {
            if (n == 50) { 
                continue;
            }
            Console.WriteLine($" {n} ");
        
        }



    }

}
