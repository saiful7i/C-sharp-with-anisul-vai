class Program
{
  public static void Main(string[] args)
  {
    int[] numbers = {10,-20,30,-40,50,0};
    
    foreach(int n in numbers){
      if (n > 0){
        Console.WriteLine(n);
      }
    }       
  }
}
