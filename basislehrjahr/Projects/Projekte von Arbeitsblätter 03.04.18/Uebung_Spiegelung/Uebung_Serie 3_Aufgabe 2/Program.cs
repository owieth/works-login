using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_Serie_3_Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    Console.Write("  ");
                }

                for (int j = i + 1; j > 0; j--)
                { 
                    Console.Write("_|"); 
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
