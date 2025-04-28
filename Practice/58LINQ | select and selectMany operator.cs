public class Person{
  public string? Name{ get; set; }
  public int Age{ get; set; }
}

class Program
{
  public static void Main(string[] args)
  {
    int[] numbers = {1,2,3,4,5,6};

    var squareNumbers=numbers.Select(num => num*num);

    foreach(int item in squareNumbers){
      Console.Write($"{item} ");      
    }
    Console.WriteLine("");

    
  
  }

}
