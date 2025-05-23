using System.Data;
using System.Diagnostics.CodeAnalysis;

class Program
{
  public static void Main(string[] args)
  {
    try
    {
      Console.Write($"How many elements you want :");
      int size = ValidIntegerInput();

      //creating the array
      int[] numbers = new int[size];

      //array initialize
      int sum = 0;
      for (int i = 0; i < numbers.Length; i++){
        Console.Write($"Enter element {i+1}:");
        int number = ValidIntegerInput();
        numbers[i] = number;        
        sum = sum + numbers[i];
      }

      //printing array
      for (int i = 0; i < numbers.Length; i++){
        Console.Write($"{numbers[i]}");
      }
      Console.WriteLine();

      //finding the max and minimum here
      int max = numbers[0];
      int min = numbers[0];
      for (int i = 0; i < numbers.Length; i++){
        if(max < numbers[i]){
          max = numbers[i];
        }
        if(min > numbers[i]){
          min = numbers[i];
        }
      }
      //Printing max & min
      Console.WriteLine($"Maximum element of the array: {max}");
      Console.WriteLine($"Maximum element of the array: {min}");
      Console.WriteLine($"Sum of this array:{sum}");
      Console.WriteLine($"Average of this array:{(double)sum / numbers.Length:F2}");
    }
     catch (OutOfMemoryException)
    {
      Console.WriteLine($"Out of Memory. Unable to create arrays with such large dimensions.");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"An error occurred: {ex.Message}");
      
    }
  }
  public static int ValidIntegerInput()
  {
        while (true)
        {
        string input = Console.ReadLine() ?? "";
        if (int.TryParse(input, out int number))
        {
          return number;
        }
        else
        {
          Console.WriteLine($"Invalid Input. Please enter valid integer.");
          
        }
        }
        
  }
}
