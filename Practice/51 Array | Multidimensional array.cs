class Program
{
  public static void Main(string[] args)
  {
    int[,] matrix = {{1,2,3} , {4,5,6} };
    for(int row=0; row<2; row++){
      for(int col=0; col<3; col++){
        Console.Write(matrix[row,col]);
      }
      Console.WriteLine();
    }  
  }
}
