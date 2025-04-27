public class Program
{
  public static void Main(string[] args)
  {
    int[] number = { 1, 2,3,5,2,6};
    
    
    
    Console.WriteLine($"Length of the array: {number.Length}");
    Console.WriteLine($"Rank of the array: {number.Rank}");
    Console.WriteLine($"Maximum value of the array:{number.Max()}");
    Console.WriteLine($"Minimum value of the array:{number.Min()}");
    Console.WriteLine($"Total value of the array:{number.Sum()}");
    Console.WriteLine($"Average value of the array:{number.Average()}");
    Console.WriteLine("Before Sorting:");    
    PrintArray(number);
    Array.Sort(number);
    Console.WriteLine("After Sorting");
    PrintArray(number);
    Array.Reverse(number);
    Console.WriteLine("After Reversing");
    PrintArray(number);
    
  }

  public static void PrintArray(int[] number){
    foreach(var item in number){
      Console.Write($"{item} ");
    }
    Console.WriteLine();  

  }
}

//length Properties= To print length of array
//Rank = to Print the dimension of the array 

//method Min(), Max(), Sum(), Average(), Sort(),Reverse()
