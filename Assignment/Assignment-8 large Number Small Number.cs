using System;
class Program
{
    public static void Main(string[] args)
    {
        int firstNumber,seconedNumber;

        Console.Write("Please Enter the First Number:");
        firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please Enter the Second Number:");
        seconedNumber = Convert.ToInt32(Console.ReadLine());

        if (firstNumber >  seconedNumber)
        {
            Console.WriteLine($"{firstNumber} is the Large Number");
            Console.WriteLine($"{seconedNumber} is the small Number");
        }
        else
        {
            Console.WriteLine($"{seconedNumber} is the Large Number");
            Console.WriteLine($"{firstNumber} is the small Number");
        }
    }

}
