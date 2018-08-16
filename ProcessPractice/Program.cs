using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the directory");
            string directoryPath = Console.ReadLine();
            Console.WriteLine("Enter the file name");
            string fileName = Console.ReadLine();

            BaseFile bf = CreateInstance(directoryPath, fileName);
            if (bf != null)
            {
                bf.OpenFile();
            }
        }

        static BaseFile CreateInstance(string directoryPath, string fileName)
        {
            BaseFile bf = null;
            string extension = Path.GetExtension(fileName);
            switch (extension)
            {
                case ".txt":
                    bf = new TxtFile(directoryPath, fileName);
                    break;
            }


            return bf;
        }
    }



    class BaseFile
    {
        public string FilePath { get; set; }
        public BaseFile(string directoryPath, string fileName)
        {
            this.FilePath = Path.Combine(directoryPath, fileName);
        }

        public void OpenFile()
        {
            ProcessStartInfo info = new ProcessStartInfo(this.FilePath);
            Process pro = new Process();
            pro.StartInfo = info;
            pro.Start();

        }
    }

    class TxtFile : BaseFile
    {
        public TxtFile(string directoryPath, string fileName)
            : base(directoryPath, fileName) { }
    }
}
