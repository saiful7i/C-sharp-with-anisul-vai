using System;

class Person
{
    public string name; //READABLE && WRITEABLE
    private int age; //not readable && writeable

    public void SetAge(int a) //writable
    {
        age = a;
    }

    public int GetAge() //readable
    {
        return age;
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
        p1.name = "Saiful Islam";
        p1.SetAge(33);
        Console.WriteLine($"p1.name = {p1.name}\np1.age= {p1.GetAge()}");

        


    }

}
