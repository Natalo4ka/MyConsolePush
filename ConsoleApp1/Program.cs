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
            Console.WriteLine("Bad request!");

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
