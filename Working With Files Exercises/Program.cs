using System;
using System.IO;
using System.Linq;

namespace Working_With_Files_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise2();
        }

        static void Exercise1()
        {
            //Write a program that reads a text file and displays the number of words.
            var path = @"C:\test\hellodoc.txt";

            var contents = File.ReadAllText(path).Split(" ");
            Console.WriteLine("You have this many words in {0}: {1} ", path, contents.Count());
        }

        static void Exercise2()
        {
            //Write a program that reads a text file and displays the longest word in the file. 
            var path = @"C:\test\hellodoc.txt";

            var contents = File.ReadAllText(path).Split(" ");

            var sorted = contents.OrderBy(n => n.Length);

            Console.WriteLine("Your shortest word is: " + sorted.LastOrDefault());
        }
    }
}
