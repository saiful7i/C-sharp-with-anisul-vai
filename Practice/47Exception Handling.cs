using System.Globalization;
public class Program
{
    public static void Main(string[] args)
    {
      try
      {
          Console.WriteLine($"Welcome to the calculator App");
        
        Console.Write($"Enter num 1 = ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write($"Enter num 2 = ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        double result = num1 / num2;
        Console.WriteLine($"{result}");
      }
      catch (OverflowException)
      {
        Console.WriteLine($"Number was too big or small for Int32");
      }
      catch (FormatException)
      {
        Console.WriteLine($"Invalid Input! Please Enter a valid integer");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        Console.WriteLine($"An Error Occured: {ex.Message}");
      }
      finally
      {
        Console.WriteLine($"Goodbye!!!");
      }
    }
}
