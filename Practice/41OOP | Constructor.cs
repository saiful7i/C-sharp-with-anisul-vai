using System;

class Person
{
    public string name;
    public int age;

    public Person()    //default Constructor
    {
        name = "test";
        age = 0;
    
    }

    public Person(string n, int a) //dynamic|parameter Constructor
    {
        name = n;
        age = a;

    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Person Name: {name} and age: {age}");

    }
}
class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("Md.Saiful Islam", 23);
        p1.DisplayInfo();

        Person p2 = new Person("Anisul Islam", 33);
        p2.DisplayInfo();

        Person p3 = new Person();
        p3.DisplayInfo();


    }

}
