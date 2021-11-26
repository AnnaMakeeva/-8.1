using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8._1
{
    class Program
    {
        static void Main()
        {
            string[] allfiles = Directory.GetFiles("F:/Работа","*.*" , SearchOption.AllDirectories);
            foreach (string filename in allfiles)
            {
                Console.WriteLine(filename);
            }

            string[] allfolders = Directory.GetDirectories("F:/Работа", "*.*", SearchOption.AllDirectories);
            foreach (string folder in allfolders)
            {
                Console.WriteLine(folder);
            }



            Console.ReadKey();

        }
    }
}
