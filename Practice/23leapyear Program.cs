using System;
class Program
{
    public static void Main(string[] args)
    {
        int years;

        Console.Write("Years:");
        years = Convert.ToInt32(Console.ReadLine());

        if (years % 400 == 0 || years % 4 == 0 && years % 100 != 0)
        {
            Console.WriteLine($"{years} is Leep Year.");
        }
        /*else if (years % 4 ==0 && years % 100 !=0)
        {
            Console.WriteLine($"{years} is Leep Year.");
        }*/
        else
        {
            Console.WriteLine($"{years} is not a Leep Year.");
        }
    }

}
