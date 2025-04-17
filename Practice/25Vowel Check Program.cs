using System;
class Program
{
    public static void Main(string[] args)
    {
        char letter;

        Console.Write("Enter any Letter:");
        letter = Convert.ToChar(Console.ReadLine());

        letter = char.ToUpper(letter);

        if (letter >= 'A' && letter <= 'Z' /*|| letter >= 'a' && letter <= 'z'*/)
        {
            if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                Console.WriteLine($"{letter} is Vowel Letter.");
            }
            /*else if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine($"{letter} is Vowel Letter.");
            }*/
            else
            {
                Console.WriteLine($"{letter} is Consonat");
            }

        }
        else
        {
            Console.WriteLine("Please Enter a Valid Letter.");
        } 

        
    }

}
