public class Program
{
  public static void Main(string[] args)
  {
    string text = "Hello everyone! This is Saiful";
    Console.WriteLine(text);
    Console.WriteLine($"Length of text: {text.Length}");
    Console.WriteLine($"0 index of text: {text[0]}");

    var Words = text.Split(" ");
    Console.WriteLine($"{string.Join(",", Words)}");
    
    foreach (var word in Words){
      Console.WriteLine($"{word}");
      
    }

    bool isEmpty = string.IsNullOrEmpty(text);
    Console.WriteLine($"Is string empty or null: {isEmpty}");

    string insertString = text.Insert(0,"Hi!");
    Console.WriteLine($"String Insert: {insertString}");

    string removeString = text.Remove(2);
    Console.WriteLine($"after Remove String: {removeString}");

    string replaceString = text.Replace("Hello everyone!","Hi!");
    Console.WriteLine($"String Insert: {replaceString}");

    bool isExist = text.Contains("Saiful");
    Console.WriteLine($"Saiful Is exit in the text:{isExist}");
    
    string reveresString = new string(text.Reverse().ToArray());
    Console.WriteLine($"Reverse String: {reveresString}");
    
    string textUpper = text.ToUpper();
    Console.WriteLine($"String with Upper Case: {textUpper}");

    string textLower = text.ToLower();
    Console.WriteLine($"String with Lower Case: {textLower}"); 

    string trimmedString = text.Trim(); //TrimStart(), TrimEnd()
    Console.WriteLine($"String with Lower Case: {trimmedString}"); 

    string substring = text.Substring(6,15); //TrimStart(), TrimEnd()
    Console.WriteLine($"substring of the text: {substring}");        
  }
}
