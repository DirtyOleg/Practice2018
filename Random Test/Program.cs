using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[2];
            persons[0] = new Person { Age = 18, Name = "David" };
            persons[1] = new Person { Age = 20, Name = "Elam" };

            Person[] other = new Person[2];
            other = persons;
            Change(other);
            Console.WriteLine(other[0].Age);
            Console.Read();
        }

        static void Change(Person[] p)
        {
            p[0].Age = 99; 
        }
    }

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
