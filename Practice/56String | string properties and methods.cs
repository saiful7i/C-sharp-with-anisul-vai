public class Program
{
  public static void Main(string[] args)
  {
    string text = "Hello everyone ! This is Saiful Islam";
    Console.WriteLine(text);
    Console.WriteLine($"Length of text: {text.Length}");
    Console.WriteLine($"0 index of text: {text[0]}");
    bool isEmpty = string.IsNullOrEmpty(text);
    Console.WriteLine($"Is string empty or null: {isEmpty}");
 
    
  }
}
