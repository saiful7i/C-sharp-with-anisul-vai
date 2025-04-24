using System;

class  Student
 {
  //Private Fields. for name,dateOfBirth & Roll
  private string? _name; //string? start with assign null for Non-nullable Property.
  private DateTime _dateOfBirth; 
  private string? _roll;

  //Properties to access in Private filed 
  public string Name{get; private set;}
  public DateTime DateOfBirth{get;private set;}
  public string Roll{get;private set;}

  //constructor to assign value for private field
  public Student(string name,DateTime dateOfBirth, string roll){
    ValidateInput(name,dateOfBirth,roll);
    Name = name;
    DateOfBirth = dateOfBirth;
    Roll = roll;
  }
 
  //Method to check Input Validate 
  private static void ValidateInput(string name, DateTime dateOfBirth,string roll){
      if(dateOfBirth > DateTime.Now){
          throw new ArgumentException("Date of birth can not be in the future");
        }
    if(string.IsNullOrWhiteSpace(name)){
          throw new ArgumentException("Name can not be Null or Empty");
        }
    if(string.IsNullOrWhiteSpace(roll)){
          throw new ArgumentException("Roll can not be Null or Empty");
        }
  }

  //Method to calculate age
  private int CalculateAge(){
    int age = DateTime.Now.Year - DateOfBirth.Year;
    //if the birthday hasn't occurred yet, decrement the age by 1
    return DateTime.Now < DateOfBirth.AddYears(age) ? age-- : age;
    }
 
  public int Age =>CalculateAge(); // using Lambda Expression 
 
 //Method to Display Student Information 
  public void StudentInformation(){
     Console.WriteLine($"Roll:{Roll}\t Name:{Name}\t Date of Birth:{DateOfBirth.ToShortDateString()} \t Age:{Age}");
  }
}

 class Program
 {
  public static void Main(string[] args)
  {
    try
    {
      Student student1 = new Student(
        "Md.Saiful Islam",new DateTime(2001,07,23),"CSE101");
      Student student2 = new Student(
        "Anisul Islam", new DateTime(2000,3,20),"CSE102");
      //Display Info
      Console.WriteLine($"====================================Student Information===================================");
      student1.StudentInformation();
      student2.StudentInformation();   
    }
    catch (Exception e)
    {
      Console.WriteLine($"Error:{e.Message}");     
    }
  }
 }

 
