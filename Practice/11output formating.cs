using System;
class Program
{
    public static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 3;

        int result;

        result = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {result}");

        result = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {result}");

        result = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {result}");

        result = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {result}");

        result = num1 % num2;
        Console.WriteLine($"{num1} % {num2} = {result}");

        double div = (double)num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {div.ToString("F4")}" );

    }

}
