using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            NetStandardLib.StdDemo d = new NetStandardLib.StdDemo();
            Console.WriteLine(d.Demo());
        }
    }
}
