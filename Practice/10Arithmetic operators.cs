using System;
class Program
{
    public static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 3;

        int result;

        result = num1 + num2;
        Console.WriteLine("Addition: " + result);

        result = num1 - num2;
        Console.WriteLine("Subtraction: " + result);

        result = num1 * num2;
        Console.WriteLine("Multipication: " + result);

        result = num1 / num2;
        Console.WriteLine("Division: " + result);
        
        result = num1 % num2;
        Console.WriteLine("Reminder: "+ result);

        double div = (double)num1 / num2;
        Console.WriteLine("Float Division: " + div.ToString("F4"));

    }

}
