using System;
class Program
{
    public static void Main(string[] args)
    {
        int number1 = 30;


        number1 += 10;
        Console.WriteLine($"{number1}"); // number1= 30+10=40

        number1 -= 20;
        Console.WriteLine($"{number1}"); //number1= 40 -20=20

        number1 *= 5;
        Console.WriteLine($"{number1}"); // number1= 20*5=100

        number1 /= 4;
        Console.WriteLine($"{number1}"); //number1= 100/4=25

        number1 %= 3;
        Console.WriteLine($"{number1}"); //number1= 25%3=1

    }

}
