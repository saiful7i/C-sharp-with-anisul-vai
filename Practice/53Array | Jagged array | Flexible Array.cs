using System.Data;

class Program
{
  public static void Main(string[] args)
  {
    int [][] jaggedArray = new int[4][];

    jaggedArray[0] = new int[] {1,2};
    jaggedArray[1] = new int[] {3,4,5};
    jaggedArray[2] = new int[] {6};
    jaggedArray[3] = new int[] {1,2};

    for (int i =0; i < jaggedArray.Length; i++){
      for (int j =0; j < jaggedArray[i].Length; j++){
        Console.Write($"{jaggedArray[i][j]}"); 
      }
      Console.WriteLine();
      
    }
      
  }
}
