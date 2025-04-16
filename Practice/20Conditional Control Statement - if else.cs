using System;
class Program
{
    public static void Main(string[] args)
    {
        int number;
        Console.Write("Please Enter a Number:");
        number = Convert.ToInt32(Console.ReadLine());
    
        if ( number > 0)
        {
            Console.WriteLine("Positive Number");

        }
        else if (number < 0)
        {
            Console.WriteLine("Negative Number");
        }

        else //if (number == 0)
        {
            Console.WriteLine("Zero");
        }


    }

}
