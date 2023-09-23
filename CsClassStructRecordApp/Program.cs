// See https://aka.ms/new-console-template for more information
using CsClassStructRecordApp;
using CsClassStructRecordApp.SubNamesSpace;

//Console.WriteLine("Hello, World!");

Fraction fraction = new Fraction(10) { numerator = 20 };

//Console.WriteLine(fraction.GetNumerator());

Person person = new Person() { age = 25, name = "Tom" };

(string myName, int myAge) = person;
(_, int otherAge) = person;

Person person2 = person;
person2.age = 33;
//Console.WriteLine(person.age);
/*
MyData d1 = new MyData();
d1.number = 123;

MyData d2 = d1;
d2.number = 555;
Console.WriteLine(d1.number);

MyData d3 = new() { number = 777 };
*/


Person p1 = new("Bob", 25, 1) { name = "Bob", age = 25 };
Person p2 = new("Bob", 25, 2) { name = "Bob", age = 25 };
Person p3 = p1;

MyData s1 = new() { name = "Bob", age = 25 };
MyData s2 = new() { name = "Joe", age = 25 };
MyData s3 = s1;

MyRecData r1 = new() { name = "Bob", age = 25 };
MyRecData r2 = new() { name = "Bob", age = 25 };
MyRecData r3 = r1;

Console.WriteLine(p1.Equals(p2));
Console.WriteLine((p1.Equals(p3)) + "\n");

Person.SMethod();
int x = Person.GUID;

Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s1.Equals(s3) + "\n");

Console.WriteLine(r1.Equals(r2));
Console.WriteLine(r1.Equals(r3) + "\n");

int n = 123;
//double x = 25.5;
string name = "Bob";
//Console.WriteLine($"n = {n}, x = {x}, name = {name}");

CsClassStructRecordApp.SubNamesSpace.Employee e = new();

Circle c1 = new Circle();
Console.WriteLine(Circle.PI);

MyData d1 = new("Bob", 23);

class Circle
{
    public const float PI = 3.14f;
    public float radius;
}


class Money
{
    public string title = "";
    public decimal amount = 0.0m;
    readonly public double rate = 10;

    public Money() { }

    public Money(double rate)
    {
        this.rate = rate;
    }
}

readonly struct MyData
{
    readonly public string name;
    readonly public int age;

    public MyData(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}



class Fraction
{
    public int numerator;

    public Fraction(int numerator)
    {
        this.numerator = numerator;
    }

    public int GetNumerator()
    {
        return numerator;
    }

    public void SetNumerator(int numerator = 0)
    {
        this.numerator = numerator;
    }
}
