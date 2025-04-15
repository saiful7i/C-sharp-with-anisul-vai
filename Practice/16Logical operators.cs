using System;
class Program
{
    public static void Main(string[] args)
    {
        //comparision operators -> ture/flase
        int number1 = 30;
        int number2 = 20;

        int number3 = 50;

        Console.WriteLine(number1> number2 && number2 < number3 );//logical AND
        Console.WriteLine(number1 > number3 || number2 < number3);//logical OR
        Console.WriteLine(!(number1 > number2 && number2 < number3));//logical NOT

        Console.WriteLine();

    }

}
