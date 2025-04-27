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

    int item = Array.IndexOf(number,2);
    Console.WriteLine($"Index of Value 2:{item}");

    bool exists = Array.Exists(number, number => number ==5);
    Console.WriteLine($"5 is Exists on the Array:{exists}");

    int[] copy = new int[number.Length];
    Array.Copy(number, copy, number.Length);

    Console.Write($"Copied Array:");
    PrintArray(copy);

    Array.Clear(copy,0, copy.Length);
    Console.Write($"after clearing the Copied Array:");
    PrintArray(copy);
    
    
    
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

//method Min(), Max(), Sum(), Average(), Sort(),Reverse(),IndexOf().Exist()
//Copy(), Clear
