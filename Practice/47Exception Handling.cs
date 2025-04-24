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
        int num2 = Convert.ToInt32(Console.ReadLine());using System.Globalization;
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
        
        if (num2 > 1000)
        {
          throw new ArgumentException("num2 can not be greater then 1000");
        }
        
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
}

        
        // if (num1 > 1 && num1 < 1000){

        // }
        
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
      catch(DivideByZeroException){
        Console.WriteLine($"Error: Can not divide by zero");
        
        
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
}
