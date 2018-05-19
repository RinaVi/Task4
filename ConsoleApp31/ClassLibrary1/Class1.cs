using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public class Directories

    {
        public void GetFolders(string dirPath)
        {
            var directories = Directory.EnumerateDirectories(dirPath, "*", SearchOption.TopDirectoryOnly);
            List<string> L1 = new List<string>();
            List<string> L2 = new List<string>();            
            try
            {
                foreach (var item in directories)
                {                                        
                    Thread thread = new Thread(GoThread); 
                    thread.Start();
                    Console.WriteLine(item);
                    L1.Add(item);//лист с содержанием директорий верхнего уровня                   
                }

                while (L1 != null&&L2!=null)
                {
                    foreach (var item in L1)
                    {
                        Thread thread1 = new Thread(GoThread);
                        thread1.Start();
                        var dirs = Directory.EnumerateDirectories(item, "*", SearchOption.TopDirectoryOnly);//подпапки в папках из верхнего уровня
                        foreach (var nitem in dirs)
                        {
                            Thread thread2 = new Thread(GoThread);
                            thread2.Start();
                            Console.WriteLine(nitem);
                            L2.Add(nitem);
                        }
                    }
                    L1.Clear();

                    foreach (var item in L2)
                    {
                        Thread thread3 = new Thread(GoThread);
                        thread3.Start();
                        var dirs = Directory.EnumerateDirectories(item, "*", SearchOption.TopDirectoryOnly);//подпапки в папках из верхнего уровня
                        foreach (var nitem in dirs)
                        {
                            Thread thread4 = new Thread(GoThread);
                            thread4.Start();
                            Console.WriteLine(nitem);
                            L1.Add(nitem);
                        }
                    }
                    L2.Clear();

                }               
                              

            }
            catch (System.UnauthorizedAccessException)
            {

            };
        }

        public void GoThread()
        {
            Thread.Sleep(50);

        }     

      

    }
}
