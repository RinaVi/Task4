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
           
            Directories d = new Directories();
            d.GetFolders(@"k:");           
            
            Console.ReadLine();
        }
    }
    
}