using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_Datentypen_Aufgabe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grundrechenoperationen mit Float und Double");
            Console.ReadLine();
            ErgebniseFloat01();
            ErgebniseFloat02();
            ErgebniseFloat03();
            ErgebniseFloat04();
            ErgebniseDouble01();
            ErgebniseDouble02();
            ErgebniseDouble03();
            ErgebniseDouble04();
        }

        private static void ErgebniseFloat01()
        {
            float WertA01 = 136.21F;
            float WertA02 = 5302.3452F;
            float WertA03 = -88.018432F;
            float WertA04 = 11.578F;

            float WertB01 = 394.234F;
            float WertB02 = 45.87394F;
            float WertB03 = 247.158320F;
            float WertB04 = -100053.2514F;

            Console.WriteLine("Addition von Float: {0}", WertA01 + WertB01);
            Console.WriteLine("Addition von Float: {0}", WertA01 + WertB02);
            Console.WriteLine("Addition von Float: {0}", WertA01 + WertB03);
            Console.WriteLine("Addition von Float: {0}", WertA01 + WertB04);
            Console.ReadLine();
        }

        private static void ErgebniseFloat02()
        {
            float WertA01 = 136.21F;
            float WertA02 = 5302.3452F;
            float WertA03 = -88.018432F;
            float WertA04 = 11.578F;

            float WertB01 = 394.234F;
            float WertB02 = 45.87394F;
            float WertB03 = 247.158320F;
            float WertB04 = -100053.2514F;

            Console.WriteLine("Subtraktion von Float: {0}", WertA01 - WertB01);
            Console.WriteLine("Subtraktion von Float: {0}", WertA01 - WertB02);
            Console.WriteLine("Subtraktion von Float: {0}", WertA01 - WertB03);
            Console.WriteLine("Subtraktion von Float: {0}", WertA01 - WertB04);
            Console.ReadLine();
        }

        private static void ErgebniseFloat03()
        {
            float WertA01 = 136.21F;
            float WertA02 = 5302.3452F;
            float WertA03 = -88.018432F;
            float WertA04 = 11.578F;

            float WertB01 = 394.234F;
            float WertB02 = 45.87394F;
            float WertB03 = 247.158320F;
            float WertB04 = -100053.2514F;

            Console.WriteLine("Multiplikation von Float: {0}", WertA01 * WertB01);
            Console.WriteLine("Multiplikation von Float: {0}", WertA01 * WertB02);
            Console.WriteLine("Multiplikation von Float: {0}", WertA01 * WertB03);
            Console.WriteLine("Multiplikation von Float: {0}", WertA01 * WertB04);
            Console.ReadLine();
        }

        private static void ErgebniseFloat04()
        {
            float WertA01 = 136.21F;
            float WertA02 = 5302.3452F;
            float WertA03 = -88.018432F;
            float WertA04 = 11.578F;

            float WertB01 = 394.234F;
            float WertB02 = 45.87394F;
            float WertB03 = 247.158320F;
            float WertB04 = -100053.2514F;

            Console.WriteLine("Division von Float: {0}", WertA01 / WertB01);
            Console.WriteLine("Division von Float: {0}", WertA01 / WertB02);
            Console.WriteLine("Division von Float: {0}", WertA01 / WertB03);
            Console.WriteLine("Division von Float: {0}", WertA01 / WertB04);
            Console.ReadLine();
        }

        private static void ErgebniseDouble01()
        {
            double WertA01 = 136.21D;
            double WertA02 = 5302.3452D;
            double WertA03 = -88.018432D;
            double WertA04 = 11.578D;

            double WertB01 = 394.234D;
            double WertB02 = 45.87394D;
            double WertB03 = 247.158320D;
            double WertB04 = -100053.2514D;

            Console.WriteLine("Addition von Double: {0}", WertA01 + WertB01);
            Console.WriteLine("Addition von Double: {0}", WertA01 + WertB02);
            Console.WriteLine("Addition von Double: {0}", WertA01 + WertB03);
            Console.WriteLine("Addition von Double: {0}", WertA01 + WertB04);

            Console.ReadLine();
        }

        private static void ErgebniseDouble02()
        {
            double WertA01 = 136.21D;
            double WertA02 = 5302.3452D;
            double WertA03 = -88.018432D;
            double WertA04 = 11.578D;

            double WertB01 = 394.234D;
            double WertB02 = 45.87394D;
            double WertB03 = 247.158320D;
            double WertB04 = -100053.2514D;

            Console.WriteLine("Subtraktion von Double: {0}", WertA01 - WertB01);
            Console.WriteLine("Subtraktion von Double: {0}", WertA01 - WertB02);
            Console.WriteLine("Subtraktion von Double: {0}", WertA01 - WertB03);
            Console.WriteLine("Subtraktion von Double: {0}", WertA01 - WertB04);

            Console.ReadLine();
        }

        private static void ErgebniseDouble03()
        {
            double WertA01 = 136.21D;
            double WertA02 = 5302.3452D;
            double WertA03 = -88.018432D;
            double WertA04 = 11.578D;

            double WertB01 = 394.234D;
            double WertB02 = 45.87394D;
            double WertB03 = 247.158320D;
            double WertB04 = -100053.2514D;

            Console.WriteLine("Multiplikation von Double: {0}", WertA01 * WertB01);
            Console.WriteLine("Multiplikation von Double: {0}", WertA01 * WertB02);
            Console.WriteLine("Multiplikation von Double: {0}", WertA01 * WertB03);
            Console.WriteLine("Multiplikation von Double: {0}", WertA01 * WertB04);
            Console.ReadLine();
        }

        private static void ErgebniseDouble04()
        {
            double WertA01 = 136.21D;
            double WertA02 = 5302.3452D;
            double WertA03 = -88.018432D;
            double WertA04 = 11.578D;

            double WertB01 = 394.234D;
            double WertB02 = 45.87394D;
            double WertB03 = 247.158320D;
            double WertB04 = -100053.2514D;

            Console.WriteLine("Division von Double: {0}", WertA01 / WertB01);
            Console.WriteLine("Division von Double: {0}", WertA01 / WertB02);
            Console.WriteLine("Division von Double: {0}", WertA01 / WertB03);
            Console.WriteLine("Division von Double: {0}", WertA01 / WertB04);
            Console.ReadLine();
        }
    }
}
