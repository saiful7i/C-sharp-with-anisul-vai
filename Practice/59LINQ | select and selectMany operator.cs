using System.Diagnostics;

public class Person{
  public string? Name{ get; set; }
  public int Age{ get; set; }
  public string? BloodGroup{ get; set; }
}
class Program
{
  public static void Main(string[] args){
  Stopwatch sw = new Stopwatch();
    sw.Start();
  {
    int[] numbers = {1,2,3,4,5,6};
    var squareNumbers=numbers.Select(num => num*num);
    foreach(int item in squareNumbers){
      Console.Write($"{item} ");      
    }
    Console.WriteLine("");
  }
  List<Person> people = new List<Person>{
    new Person {Name = "Saiful",Age = 23, BloodGroup= "A+"},
    new Person {Name = "Anisul",Age= 33, BloodGroup= "B-"},
    new Person {Name = "Ovi",Age=34, BloodGroup= "O+"},
    new Person {Name = "Alia",Age=18, BloodGroup= "AB+"},
    new Person {Name = "Nusrat",Age=42, BloodGroup= "A-"},
  };
  var Name= people.Select(person => (person.Name, person.BloodGroup));
  foreach(var item in Name){
    Console.WriteLine(item.Name+" ="+item.BloodGroup);
  }
  Console.WriteLine("");
  List<List<int>> nestedList = new List<List<int>>{
    new List<int>{1,2,3,4,5},
    new List<int>{4,5,6},
    new List<int>{7,8},
    new List<int>{9},
  }
  var flattedList = nestedList.SelectMany(list=> list);
  foreach(var item in flattedList){
    Console.Write(item+" ");
  }
  Console.WriteLine("");
  sw.Stop();
  Console.WriteLine($"Time:{sw.ElapsedMilliseconds}ms");
}
}
