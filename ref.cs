using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            add(ref i,78);
            Console.WriteLine("i={0}", i);
            Console.ReadKey();

        }
        static void add(ref int a , int b)
        {
            a = 10;
            int c = a + b;
            Console.WriteLine("a+b={0}", c);
        }
    }
}
