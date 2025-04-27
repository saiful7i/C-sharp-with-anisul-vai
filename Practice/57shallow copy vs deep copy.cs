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

    Console.WriteLine("===========================================");

    int[] originalArray2 = { 1,2,3,4,5,6,7};
    int[] deepCopy = new int[originalArray2.Length];
    Array.Copy(originalArray2, deepCopy,originalArray2.Length);//To copy Array. Array.Copy(copy form,destination,length)
    Console.WriteLine($"Original Array before modification:");
    PrintArray(originalArray2);

    Console.WriteLine($"Shallow Copy of Array before modification:");
    PrintArray(deepCopy);

    deepCopy[0] = 10;
    Console.WriteLine($"Original Array before modification:");
    PrintArray(originalArray2);

    Console.WriteLine($"Shallow Copy of Array before modification:");
    PrintArray(deepCopy);

  }
  public static void PrintArray(int[] array){
    foreach (int i in array){
      Console.Write($"{i} ");      
    }
    Console.WriteLine("");
  }
}
