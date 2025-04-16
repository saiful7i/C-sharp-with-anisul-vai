using System;
class Program
{
    public static void Main(string[] args)
    {
        char letter;

        Console.Write("Enter any Letter:");
        letter = Convert.ToChar(Console.ReadLine());

        if (letter >= 'A' && letter <= 'Z')
        {
            Console.WriteLine($"{letter} is Captial Letter.");
        }
        else if (letter >= 'a' && letter <= 'z')
        {
            Console.WriteLine($"{letter} is Small Letter.");
        }
        else
        {
            Console.WriteLine("Please Enter a Valid Letter.");
        }
    }

}
