using System;
class Program
{
    public static void Main(string[] args)
    {
        int result = 9 > 10 ? 9 : 8;
        Console.WriteLine(result);

        int num1 = 13;
        int num2 = 23;

        int largeNumber= num1 > num2 ? num1 : num2;
        Console.WriteLine(largeNumber);

    }

}
