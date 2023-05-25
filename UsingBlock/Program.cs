using System;
using System.IO;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/home/victorvale20/file1.txt";

            try
            { 
                // UsingBlock
                using (StreamReader sr = File.OpenText(path))
                { 
                    while (!sr.EndOfStream)
                    {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error acurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}