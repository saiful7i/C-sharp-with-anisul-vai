public class Program
{
  public static void Main(string[] args)
  {
    int[] numbers = { 4,6,7,1,9,2};
    Console.WriteLine($"Order By Ascending");
    var sortedNumbersAscending= numbers.OrderBy(num => num);
    
    foreach (var item in sortedNumbersAscending)
    {
      Console.Write($"{item} ");
    }
    Console.WriteLine("");

    Console.WriteLine($"Order By Descending");
    var sortedNumbersDescending= numbers.OrderByDescending(num => num);
    foreach(var item in sortedNumbersDescending){
      Console.Write($"{item} ");
    }
  }
}
