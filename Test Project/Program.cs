using System;
using System.Runtime.InteropServices;

namespace Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Record r = new Record() { id = 0 };
            
            Console.WriteLine($"({Marshal.SizeOf(r)})");
            Console.Read();
        }
    }

    struct Record
    {
        public int id;
        const string nothing = "Place Holder";
    }
}
