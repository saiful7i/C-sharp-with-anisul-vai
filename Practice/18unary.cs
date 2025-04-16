using System;
class Program
{
    public static void Main(string[] args)
    {
        int number = 10;
        //Post Increment
        Console.WriteLine(number++);//10
        Console.WriteLine(number++);//11
        Console.WriteLine(number);//12

        //Pre Increment
        Console.WriteLine(--number);//11
        Console.WriteLine(++number);//12

    }

}
