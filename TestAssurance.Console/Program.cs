using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssurance.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sorted = StringSorter.Sort(args);
            System.Console.WriteLine(string.Join(",", sorted));
        }
    }
}
