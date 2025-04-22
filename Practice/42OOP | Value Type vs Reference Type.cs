using System;

class Person
{
    public string name;
    public int age;

  
    //public Person(string n, int a) //constructor
    //{
    //    name = n;
    //    age = a;

    //}

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
        p1.name = "Saiful Islam";
        p1.age = 23;
        Console.WriteLine($"before refering:\np1.name = {p1.name}\np1.age= {p1.age}");

        Person p2 = p1; //Reference
        p1.name = "Anisul Islam";
        p1.age = 33;
        Console.WriteLine($"p2.name = {p2.name}\np2.age= {p2.age}");

        Console.WriteLine($"after refering:\np1.name = {p1.name}\np1.age= {p1.age}");


    }

}
