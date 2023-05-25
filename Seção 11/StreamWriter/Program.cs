using System;
using System.IO;

namespace StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"/home/victorvale20/file1.txt";
            string targetPath = @"/home/victorvale20/file2.txt";
            
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (System.IO.StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);

            }
        }
    }
}