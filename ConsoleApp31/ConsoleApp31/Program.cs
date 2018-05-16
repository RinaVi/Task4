using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {

        static void Main(string[] args)
        {

            var dirPath = @"k:";
            var directories = Directory.EnumerateDirectories(dirPath, "*", SearchOption.TopDirectoryOnly);
            try
            {
                foreach (var item in directories)
                {
                    Console.WriteLine(item);
                    foreach (var folder in Directory.GetDirectories(item))
                        Console.WriteLine("1" + folder);
                }
            }
            catch (System.UnauthorizedAccessException)
            {

            };
            
            Console.ReadLine();
        }
    }
    
}