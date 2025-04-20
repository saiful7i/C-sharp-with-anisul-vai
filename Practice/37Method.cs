
using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Threading.Channels;
class Program
{
    public static void Message(string text) //text parameter
    {
        Console.WriteLine(text);
    }
    public static void Add(int number1,int number2)
    {
        int result = number1 + number2;
        Console.WriteLine($"{number1} + {number2}= {result}");
    }
    public static void Subtraction(int number1, int number2)
    {
        int result = number1 - number2;
        Console.WriteLine($"{number1} - {number2}= {result}");
    }

    public static int Square(int number)
    {
        return number * number;
    }

    public static void Main(string[] args)
    {
        
        Message("Welcome to Calculator");//parameter passing
        Add(10,20);
        Add(50,30);
        Add(50,40);

        Subtraction(50, 20);
        Subtraction(100,20);

        int result = Square(5);
        Console.WriteLine($"Square of 5 is : {result}");
        

       

        //Console.Read();
        Message("Thank you for using Calculator"); //parameter passing

    }

}
