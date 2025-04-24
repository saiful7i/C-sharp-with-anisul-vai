using System.Data;

class Program
{
  public static void Main(string[] args)
  {
    int [][] jaggedArray = {
      new [] {1,2},
      new [] {3,4,5},
      new [] {6},
      new [] {1,2}
    };

    foreach (var row in jaggedArray){
      foreach (var item in row){
        Console.Write($"{item}");
      }
      Console.WriteLine();
    }
  }
}
