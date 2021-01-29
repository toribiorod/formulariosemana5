using System;
using System.IO;
namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@".\hello.txt", "Hello World");
            foreach (string file in Directory.GetFiles(@".\"))
            {
                Console.WriteLine(file);
            }
            string[] files = Directory.GetFiles(@".\", "*", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
        }
    }
}
