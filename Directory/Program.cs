using System;
using System.Collections.Generic;

namespace Directory
{
    class Program 
    {
        static void Main(string[] args)
        {
            string path = @"/home/victorvale20/myfolder";

            try
            {
                var folders = System.IO.Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                
                var files = System.IO.Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                System.IO.Directory.CreateDirectory(path + "/newfolder");
            }

            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}