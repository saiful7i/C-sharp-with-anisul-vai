using System;
using System.Threading.Channels;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number between 1 to 10:");
        //int number = Convert.ToInt32(Console.ReadLine());

        //switch (number)
        //{
        //    case int num when num <1 || num > 10:
        //        Console.WriteLine($"{num} is Out of range");
        //        break;
        //    case int num when num % 2 == 0:
        //        Console.WriteLine($"{num} is Even Number");
        //        break;
        //    case int num when num % 2 == 1:
        //        Console.WriteLine($"{num} is Odd Number");
        //        break;
        //    default:
        //        Console.WriteLine("Invalid Number");
        //        break;
        //}

        //switch short hand

        if (int.TryParse(Console.ReadLine(),out int number) )
        {
            string resutl = number switch
            {
                //int num when num < 1 || num > 10 => "Number is of range",
                //int num when num%2 == 0 => "Even Number",
                //int num when num%2 != 0 => "Odd Number",
                //_ => "Please input a number."
                int num when num >= 1 && num <= 10 => num % 2 == 0 ? "Even number " : "Odd Number",
                _ => "Number is out range"

            };
            Console.WriteLine(resutl);

        }
        else {
            Console.WriteLine($"Invalid Input. Please Enter a valid number");
        }
        

        

    }

}
