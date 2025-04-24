class Program
{
  public static void Main(string[] args)
  {
    string[] names = { "anisul", "nusrat","alex","hanif"};
    for (int i=0; i<names.Length; i++){
      Console.WriteLine($"{names[i]}");  
    }
    foreach(string name in names){
      Console.WriteLine($"{name}");
      
    }
  }
}
