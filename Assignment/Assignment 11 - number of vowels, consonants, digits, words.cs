public class Program
{
  public static void Main(string[] args)
  {
    string input = "Hello 123 world!";

    int vowelCount = input.Count(c => "aeiouAEIOU".Contains(c));
    int consonantCount = input.Count(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c));
    int digitCount = input.Count(c => char.IsAsciiDigit(c) );
    int specialCharCount = input.Count(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));
    int whiteSpaceCount = input.Count(char.IsWhiteSpace);


    int wordCount = input.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).Length;
    
    Console.WriteLine($"Number of vowel: {vowelCount}");
    Console.WriteLine($"Number of consonant: {consonantCount}");
    Console.WriteLine($"Number of Digit: {digitCount}");
    Console.WriteLine($"Number of Special Character: {specialCharCount}");
    Console.WriteLine($"Number of White Space: {whiteSpaceCount}");
    Console.WriteLine($"Number of word: {wordCount}");

  }
}
