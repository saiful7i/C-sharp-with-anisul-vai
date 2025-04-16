using System;
class Program
{
    public static void Main(string[] args)
    {
        int firstNumber,seconedNumber,thirdNumber;

        Console.Write("Please Enter the First Number:");
        firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please Enter the Second Number:");
        seconedNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please Enter the Third Number:");
        thirdNumber = Convert.ToInt32(Console.ReadLine());

        if (firstNumber > seconedNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine($"{firstNumber} is the Largest Number");
            
            if (seconedNumber < thirdNumber)
            {
                Console.WriteLine($"{seconedNumber} is the small Number");
            }
            else
            {
                Console.WriteLine($"{thirdNumber} is the small Number");
            }

        }
        else if (seconedNumber > thirdNumber ) 
        {
            Console.WriteLine($"{seconedNumber} is the Largest Number");
            if (firstNumber < thirdNumber)
            {
                Console.WriteLine($"{firstNumber} is the small Number");
            }
            else
            {
                Console.WriteLine($"{thirdNumber} is the small Number");
            }
        }
        else 
        {
            Console.WriteLine($"{thirdNumber} is the Largest Number.");
            if (firstNumber < seconedNumber)
            {
                Console.WriteLine($"{firstNumber} is the small Number");
            }
            else
            {
                Console.WriteLine($"{seconedNumber} is the small Number");
            }
        }
         
    }

}
