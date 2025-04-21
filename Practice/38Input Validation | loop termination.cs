using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Threading.Channels;
class Program
{
    public static int CalculateSquare(int num)
    {
        return num * num;
    } 


    public static void Main(string[] args)
    {
        //Console.WriteLine("Please Enter Number 1-10:");
        //int num = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            Console.Write($"Enter a Number from 1 to 10 or write quite to exit the app:");
            string input = Console.ReadLine() ?? "";
            input = input.ToLower().Trim();

            if(input == "quit")
            {
                Console.WriteLine($"Thanks for using your app. \nGoodbye!!!");
                break;
            }
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine($"Invalid Number . Enter number only input");
                continue;
            }
            if (!(number >= 1 && number <= 10))
            {
                
                Console.WriteLine($"Out of range. Please Enter between 1-10.");
                continue;
            }
            
            Console.WriteLine($"Square of {number} = {CalculateSquare(number)}");

        }
    }

}
