using System;
class Program
{
    public static void Main(string[] args)
    {
        //BITWISE Operator = AND($), OR(|), XOR(^) , RIGHT SHIFT(>>),LEFT SHIFT(<<), NOT(!)
        int number1 = 15;
        int number2 = 12;
        int result; 

        //bitwise and
        result = number1 & number2;
        Console.WriteLine($"{number1} & {number2}={result}");

        //bitwise or 
        result = number1 | number2;
        Console.WriteLine($"{number1} | {number2}={result}");

        //bitwise xor 
        result = number1 ^ number2;
        Console.WriteLine($"{number1} ^ {number2}={result}");

        //bitwise right shift 
        result = number1 >> 2;
        Console.WriteLine($"{number1} >> {2}={result}");

        //bitwise left shift 
        result = number1 << 2;
        Console.WriteLine($"{number1} << {2}={result}");

    }

}
