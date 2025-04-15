sing System;
class Program
{
    public static void Main(string[] args)
    {
        double fahrenheit, celcius;
        Console.WriteLine("==========Temperature Calculator============");

        Console.Write("Pleae Give the Temperature in Fahrenhiet:");
        fahrenheit = double.Parse(Console.ReadLine());

        celcius = (fahrenheit - 32) / 1.8;

        Console.WriteLine($"Temperature is {celcius:F2} degrees");

    }

}
