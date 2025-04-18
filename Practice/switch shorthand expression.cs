using System;
using System.Threading.Channels;
class Program
{
    public static void Main(string[] args)
    {
        string day;
        Console.Write("Please Type a Day in Full Form:");
        day = Console.ReadLine();


        string result = day.ToLower() switch
        {
            "sunday" => "is weekday",
            "monday" => "is weekday",
            "tuesday" => "is weekday",
            "wednesday" => "is weekday",
            "thursday" => "is weekday",
            "friday" => "is weekend",
            "saturday" => "is weekend",
            _ => "it's an invalid day."

        };
        Console.WriteLine($"{day} {result}");
        
    }

}
