using System;
using System.Threading.Channels;
class Program
{
    //Project-2 | basic calculator
    public static void Main(string[] args)
    {
        double num1, num2,result;
        char opreation;

        Console.WriteLine("==========Basic Calculator==========");
        Console.Write("Enter and operation(+,-,*,/):");
        opreation = Convert.ToChar(Console.ReadLine());
        Console.WriteLine();

        

        if (opreation == '+' || opreation == '-' || opreation == '*' || opreation == '/')
        {
            Console.Write("Please Enter number1:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter number2:");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (opreation)
            {
                case '+':
                    result  = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result:F2}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result:F2}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result:F2}");
                    break;
                case '/':
                    if (num2 != 0) { 
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Can not divide by Zero");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Choose.");
                    break;
            }

        }
        else
        {
            Console.WriteLine("Invalid Choose.");
        }



    }

}
