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
      catch (ArgumentNullException)
      {
        Console.WriteLine($"Error: Input can not be null.");
        
      }
      catch (OverflowException)
      {
        Console.WriteLine($"Number was too big or small for Int32");
      }
      catch (FormatException)
      {
        Console.WriteLine($"Invalid Input! Please Enter a valid integer");
      }
      catch(DivideByZeroException){
        Console.WriteLine($"Error: Can not divide by zero");        
      }
      catch(ArgumentException e)
      {
        Console.WriteLine($"{e.Message}");        
      }
      catch (Exception ex)
      {
        Console.WriteLine($"{ex}");
        Console.WriteLine($"An Error Occured: {ex.Message}");
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
          if (string.IsNullOrEmpty(input))   
          {
            Console.WriteLine("num1 can not be null or empty");
            continue;
          }
          try
          {
            return Convert.ToInt32(input);
          }
          catch(FormatException)
          {
            Console.WriteLine($"Invalid Input ! Please enter a valid integer");
          }
        }
    }
}
