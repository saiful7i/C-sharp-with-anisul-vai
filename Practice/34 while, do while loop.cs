using System;
using System.Threading.Channels;
class Program
{
   
    public static void Main(string[] args)
    {
        // while loop
        int i = 1; // initializer

        while (i <= 10) //condition
        {
            Console.WriteLine(i);
            i++; //update
        }

        // do while loop
        int n = 1; // initializer

        do
        {
            Console.WriteLine(n);
            n++; //update
        } while (n <= 10) ; //condition

    }

}
