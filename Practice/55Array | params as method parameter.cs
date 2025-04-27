public class Program
{
  public static int Sum(params int[] number){ //params key word to use multiple parameters
    int sum = 0;
    foreach(int i in number){
      sum += i;
    }
    return sum;
  }
  public static void Main(string[] args)
  {
    Console.WriteLine($"{Sum(5,4)}");
    Console.WriteLine($"{Sum(5,4,3)}");
    Console.WriteLine($"{Sum(5,4,5,7)}");
    Console.WriteLine($"{Sum(5,4,3,1,4)}");
    
  }
}
