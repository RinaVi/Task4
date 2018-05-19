using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {

        static void Main(string[] args)
        {
           
            Directories d = new Directories();
            Console.WriteLine("Please,enter the name of the folder to be scanned(Like 'c:')");
            d.GetFolders(@Console.ReadLine());          

            Console.ReadLine();
        }
    }
    
}