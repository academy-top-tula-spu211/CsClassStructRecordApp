using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsClassStructRecordApp
{
    public class Person
    {
        public const int GUID = 5;

        public string name;
        public int age;
        readonly int id;

        public Person() : this("", 0, 0)
        {
        }

        public Person(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public void Deconstruct(out string name, out int age)
        {
            name = this.name;
            age = this.age;
        }

        public static void SMethod()
        {
            Console.WriteLine("Static method");
        }
    }

    namespace SubNamesSpace
    {
        public class Employee
        {

        }
    }
}
