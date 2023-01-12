using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piramida_ot_chisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            var n = int.Parse(Console.ReadLine());


            int temp = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int a = 0; a < i; a++)
                {
                    Console.Write($"{temp++} ");
                    if (temp == (n + 1))
                        break;
                }
                if (temp == (n + 1))
                    break;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}                     // Anton i Nikola Luchev 
