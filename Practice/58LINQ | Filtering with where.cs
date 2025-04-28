
class Student
{
  //Property of Student Class
  public string? Name{
    get; set;
  }
  public int Score{
    get; set;
  }
}

public class Program
{
  
  public static void Main(string[] args)
  {
    List<int> numbers = new List<int>{1,2,6,8,5,3,7};
    var evenNumbers = numbers.Where(num => num%2 == 0);
    Console.WriteLine($"Count of Even Numbers:"+evenNumbers.Count());
    if(evenNumbers.Any()){
      Console.WriteLine($"Even Numbers:");
      foreach(int i in evenNumbers){
      Console.Write($"{i} ");
      }
      Console.WriteLine("");
    }
    else{
      Console.WriteLine($"No Even Number Found");
    }
   

   Console.WriteLine("====================================");
    List<string> words = new List<string>{"apple","orange","banana","kiwi"};
    var longWords = words.Where(word => word.Length>4);
    Console.WriteLine($"Count of Long Words:"+longWords.Count());
    
    if(longWords.Any()){
      Console.WriteLine($"Even Numbers:");
      foreach(string i in longWords){
      Console.Write($"{i} ");
      }
      Console.WriteLine("");
    }
    else{
      Console.WriteLine($"No long words Found");
      
    }


     Console.WriteLine("====================================");
    List<Student> students = new List<Student>{
      new Student{Name = "Saiful", Score = 95},
      new Student{Name = "Bob",Score=80},
      new Student{Name = "Anisul",Score=99},
      new Student{ Name = "Marley",Score=75},
      new Student{ Name = "Alia",Score= 55}
    };

    var studentWithScoreMoreThen80 = students.Where(students => students.Score >= 80);

    Console.WriteLine($"Count of Students with score more then 80:"+studentWithScoreMoreThen80.Count());
    
    foreach(Student student in studentWithScoreMoreThen80){
      Console.WriteLine(""+student.Name+", "+student.Score);
    }
    Console.WriteLine("");

    

    
  }
  
}

//Filtration with where
//Filtration with where
