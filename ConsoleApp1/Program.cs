using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static readonly Test t = new Test();
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("1");
            StringBuilder sb2 = new StringBuilder("1");
            Console.WriteLine(sb==sb2);
            Console.WriteLine(sb.Equals(sb2));
            t.Name = "namena";
            //t = new Test();
            const int[] d = { 1, 2, 3 };

        }
    }
    class Test:Some
    {
        public string Name;
    }
    struct Some
    {

    }

}
