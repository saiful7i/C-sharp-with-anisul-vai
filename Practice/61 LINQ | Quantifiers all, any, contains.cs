
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
      new Person{Name="Bob",Age=16},
      new Person{Name="Alice",Age=15}
    };

    bool adultPeople = people.All(person => person.Age >=18);
    Console.WriteLine($"Are all People Adults? {adultPeople}");

    bool anyTeenAger = people.Any(person => person.Age <20);
    Console.WriteLine($"Is there any teenager?: {anyTeenAger}");

    bool containAlice = people.Select(person => person.Name).Contains("Alice");
    Console.WriteLine($"Does this collections contain Alice?: {containAlice}");
    
  }
}

//LINQ: Quantifiers all, any, contains
