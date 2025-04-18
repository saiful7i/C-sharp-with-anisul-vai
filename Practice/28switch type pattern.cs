using System;
using System.Threading.Channels;
class Program
{
    public static void Main(string[] args)
    {
        object number = "abcd";

        string result = number switch
        {
            int => "Integer",
            double => "Double",
            float => "Float",
            string => "String",
            _ => "unknown Type"
        };
        Console.WriteLine(result);
        

    }

}
