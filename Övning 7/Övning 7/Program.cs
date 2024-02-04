using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_7
{
    internal class Program
    {
        static void grafRuta(string name, int summa)
        {
            Console.WriteLine($"{name} donerade {summa}");

        }
        static void Main(string[] args)
        {
            grafRuta("Arvid", 10000);

        }
    }
}
