public class Person
{
  public string? Name{ get; set; }
  public int Age{ get; set; }
}
public class Program
{
  public static void Main(string[] args)
  {
    List<Person> people= new List<Person>{
      new Person{Name="Saiful",Age=23},
      new Person{Name="Anisul",Age=33},
      new Person{Name="Nusrat",Age=18},
      new Person{Name="Bob",Age=36},
      new Person{Name="Alice",Age=20}
    };

    Console.WriteLine($"People Sorted By Name");
    var sortedPeopleByName = people.OrderBy(person =>person.Name);
    foreach(var item in sortedPeopleByName){
      Console.WriteLine($"{item.Name} : {item.Age}");
    }

    Console.WriteLine($"People Sorted By Age");
    var sortedPeopleByAge = people.OrderBy(person => person.Age);
    foreach(var item in sortedPeopleByAge){
      Console.WriteLine($"{item.Name} : {item.Age}");
    }

    // int[] numbers = { 4,6,7,1,9,2};
    // Console.WriteLine($"Order By Ascending");
    // var sortedNumbersAscending= numbers.OrderBy(num => num);
    
    // foreach (var item in sortedNumbersAscending)
    // {
    //   Console.Write($"{item} ");
    // }
    // Console.WriteLine("");

    // Console.WriteLine($"Order By Descending");
    // var sortedNumbersDescending= numbers.OrderByDescending(num => num);
    // foreach(var item in sortedNumbersDescending){
    // Console.Write($"{item} ");
    // }
  }
}

//LINQ: OrderBy, OrderByDesc, ThenBy for sorting
