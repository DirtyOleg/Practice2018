using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            People[] peoples = { new People("a", 13), new Student("b", 17), new Teacher("c", 37) };
            foreach (var item in peoples)
            {
                item.SayHello();
            }
            Console.Read();
        }
    }

    class People
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public People(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void SayHello()
        {
            Console.WriteLine("I am people");
        }
    }

    class Student : People
    {
        public Student(string name, int age):base(name,age)
        { }

        public new void SayHello()
        {
            Console.WriteLine("I am student");
        }
    }

    class Teacher:People
    {
        public Teacher(string name,int age):base(name,age)
        { }

        public new void SayHello()
        {
            Console.WriteLine("I am teacher");
        }
    }
}
