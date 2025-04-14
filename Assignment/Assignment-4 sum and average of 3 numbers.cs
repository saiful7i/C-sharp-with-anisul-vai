using System;
class Program
{
    public static void Main(string[] args)
    {
        int num1, num2, num3;
        int sum;
        float avg;

        Console.Write("Enter Number 1:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Number 2:");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Number 3:");
        num3 = Convert.ToInt32(Console.ReadLine());


        sum = num1 + num2 + num3;

        avg = (float)sum / 3;

        Console.WriteLine($"SUM of this 3 Number: {sum}");
        Console.WriteLine($"Average of the Sum : {avg.ToString("F2")}");



    }

}
