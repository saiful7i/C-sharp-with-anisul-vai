using System;
class Program
{
    public static void Main(string[] args)
    {
        //switch, break, case, default

        int digit;
        Console.Write("Please Enter a Digit Between 0-9:");
        digit = Convert.ToInt32(Console.ReadLine());

        switch (digit)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;  
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;  
            case 6:
                Console.WriteLine("Six");
                break;  
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("Pleae Enter a Valid Digit.");
            break;
        }

        
    }

}
