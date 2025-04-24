using System.Globalization;
public class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine($"Welcome to the calculator App");
      try
      {
       int num1 = ReadIntegerInput("num1");
       int num2 = ReadIntegerInput("num2");        
        
        double result = num1 / num2;
        Console.WriteLine($"{result}");
      }
      // catch(DivideByZeroException){
      //   Console.WriteLine($"Error: Can not divide by zero");        
      // }
      // catch(ArgumentException e)
      // {
      //   Console.WriteLine($"{e.Message}");        
      // }
      catch (Exception ex)
      {
        Console.WriteLine($"{ex}");
        Console.WriteLine($"An Error Occurred: {ex.Message}");
      }
      finally
      {
        Console.WriteLine($"Goodbye!!!");
      }
    }
    static int ReadIntegerInput(string prompt)
    {
        while (true)
        {
            Console.Write($"Enter {prompt} = ");
            string input = Console.ReadLine() ?? "";
            if (!int.TryParse(input, out int result) || string.IsNullOrEmpty(input))   
            {
             Console.WriteLine($"Invalid Input! Please Enter a valid Integer");
             continue;
            }
            return result;   
        }
    }
}

