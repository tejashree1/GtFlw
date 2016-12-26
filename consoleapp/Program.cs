using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.ReadLine();
        }
    }
}
