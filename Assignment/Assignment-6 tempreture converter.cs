using System;
class Program
{
    public static void Main(string[] args)
    {
        double fahrenheit, celcius;
        Console.WriteLine("==========Temperature Calculator============");

        Console.Write("Pleae Give the Temperature in Celcius Scale:");
        celcius = double.Parse(Console.ReadLine());

        fahrenheit = (celcius*9/5) +32;

        Console.WriteLine($"Temperature is {fahrenheit:F2}°F");

    }

}
