using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassOfGS myNewObject = new ClassOfGS();
            int i = GC.GetGeneration(myNewObject);
            Console.WriteLine("Current generation of object is {0}", i);
            GC.Collect();
            i = GC.GetGeneration(myNewObject);
            Console.WriteLine("Current generation of object is {0}", i);
            GC.Collect();
            i = GC.GetGeneration(myNewObject);
            Console.WriteLine("Current generation of object is {0}", i);
            Console.Read();
        }
    }
}
