using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssemblyTest
{
    class GCExample
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("GC maximum generations:" + GC.MaxGeneration);
            Console.ReadKey();
        }
    }
}
