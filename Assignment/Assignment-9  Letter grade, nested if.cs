using System;
class Program
{
    public static void Main(string[] args)
    {
        int mark;

        Console.Write("Enter the Mark:");
        mark = Convert.ToInt32(Console.ReadLine());

        if (mark > 0 && mark <= 100)
        {
            if (mark >= 90 )
            {
                Console.WriteLine("Your Grade is: A");
            }
            else if (mark >= 80 )
            {
                Console.WriteLine("Your Grade is: B");
            }
            else if (mark >= 70 )
            {
                Console.WriteLine("Your Grade is: C");
            }
            else if (mark >= 60 )
            {
                Console.WriteLine("Your Grade is: D");
            }
            else //if (mark < 60)
            {
                Console.WriteLine("Your Grade is: F");
            }
        }
        else
        {
            Console.WriteLine("Please Enter a Valid Mark!");
        }
        
    }

}
