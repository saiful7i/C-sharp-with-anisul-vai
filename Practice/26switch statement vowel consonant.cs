using System;
using System.Threading.Channels;
class Program
{
    public static void Main(string[] args)
    {
        //switch, break, case, default

        char letter;
        Console.Write("Please Enter a letter:");
        letter = Convert.ToChar(Console.ReadLine());
        
        letter = char.ToUpper(letter);

        if(letter >= 'A' && letter <= 'Z')
        {
            switch(letter)
            {
                case 'A':
                    Console.WriteLine($"{letter} is Vowel");
                    break;
                case 'E':
                    Console.WriteLine($"{letter} is Vowel");
                    break;
                case 'I':
                    Console.WriteLine($"{letter} is Vowel");
                    break;
                case 'O':
                    Console.WriteLine($"{letter} is Vowel");
                    break;
                case 'U':
                    Console.WriteLine($"{letter} is Vowel");
                    break;
                default:
                    Console.WriteLine($"{letter} is Consonant");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Please Enter a Valid Charecter.");
        }
        
    }

}
