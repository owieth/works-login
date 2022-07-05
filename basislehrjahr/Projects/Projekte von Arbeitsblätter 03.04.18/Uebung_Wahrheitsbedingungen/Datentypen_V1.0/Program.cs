
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Datentypen_V1._0
{
    class Program
    {
        static int a;
        static int b;
        static int c;

        static void Main(string[] args)
        {
            int ZahlAEingabe;
            int ZahlBEingabe;
            int ZahlCEingabe;
            Console.WriteLine("Bitte geben Sie den Wert von 'A', 'B' und 'C' an.");
            Console.Write("A: ");
            ZahlAEingabe = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            ZahlBEingabe = Convert.ToInt32(Console.ReadLine());
            Console.Write("C: ");
            ZahlCEingabe = Convert.ToInt32(Console.ReadLine());
            
            a = ZahlAEingabe;
            b = ZahlBEingabe;
            c = ZahlCEingabe;

            Value01();
            Console.ReadLine();
            Value02();
            Console.ReadLine();
            Value03();
            Console.ReadLine();
            Value04();
            Console.ReadLine();
            Value05();
            Console.ReadLine();
            Value06();
            Console.ReadLine();
        }

        private static void Value01()
        {
            if (a < b)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        private static void Value02()
        {
            if (a >= 0 && b < 20)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        private static void Value03()
        {
            if (a < 5 && b <= 105 || b == 100) 
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        private static void Value04()
        {
            if (a == 15 && b > 130 - a || b - a != 90)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        private static void Value05()
        {
            if (a < c && b < c && a!=b)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        private static void Value06()
        {
            if (a < b && (c == 40 || a + b > 40) && 80 - b > 50)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
