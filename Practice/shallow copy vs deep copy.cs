public class Program
{
  public static void Main(string[] args)
  {
    int[] originalArray = { 1,2,3,4,5,6,7};
    int[] shallowCopy = originalArray;
    Console.WriteLine($"Original Array before modification:");
    PrintArray(originalArray);

    Console.WriteLine($"Shallow Copy of Array before modification:");
    PrintArray(shallowCopy);

    shallowCopy[0] = 10;
    Console.WriteLine($"Original Array after modification:");
    PrintArray(originalArray);

    Console.WriteLine($"Shallow Copy of Array after modification:");
    PrintArray(shallowCopy);
    

  }
  public static void PrintArray(int[] array){
    foreach (int i in array){
      Console.Write($"{i} ");      
    }
    Console.WriteLine("");

  }
}
