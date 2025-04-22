using System;

class Person
{
    private string name; 
    private int age; 

    public string Name
    {
        //get { return name; }
        //set {  name = value; }
        get; set; //shorthand getset
        //{
        //    if (value.Length >= 2) 
        //    { 
        //        name = value; 
        //    }
        //}
    }
    public int Age
    {
        //get { return age; }
        //set { age = value; }
        get; set; // shorthand getset method
        //{
        //    if (value > 0)
        //    {
        //        age = value;
        //    }
        //}
    }
    public void DisplayInfo() //method
    {
        Console.WriteLine($"Person Name: {name} and age: {age}");

    }
}
class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Name = "Saiful Islam";
        p1.Age =33;
        Console.WriteLine($"p1.name = {p1.Name}\np1.age= {p1.Age}");

        


    }

}
