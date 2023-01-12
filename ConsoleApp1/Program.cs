using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Дай число:");
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i+=3)
            {
                Console.WriteLine(i);
                // Anton i Nikola Luchev
            }
        }
    }
}
