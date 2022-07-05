using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUebungen
{
    class Program
    {
        static void Main(string[] args) //23.03.2018 Vergleich zwischen Float und Double
        {
            Console.WriteLine("Hallo ich bims Marcel Davis");

            float floatZahlEins = 1231.1239881230F;
            float floatZahlZwei = 1213.2340023040F;

            double doubleZahlEins = 1231.1239881230D;
            double doubleZahlZwei = 1213.2340023040D;

            decimal decimalZahlEins = 1231.1239881230M;
            decimal decimalZahlZwei = 1213.2340023040M;

            Console.WriteLine("Addition float: {0}", floatZahlEins + floatZahlZwei);
            Console.WriteLine("Addition double: {0}", doubleZahlEins + doubleZahlZwei);
            Console.WriteLine("Addition decimal: {0}", decimalZahlEins + decimalZahlZwei);
            Console.WriteLine();

            Console.WriteLine("Subtraktion float: {0}", floatZahlEins - floatZahlZwei);
            Console.WriteLine("Subtraktion double: {0}", doubleZahlEins - doubleZahlZwei);
            Console.WriteLine("Addition decimal: {0}", decimalZahlEins - decimalZahlZwei);
            Console.WriteLine();

            Console.WriteLine("Mulitiplikation float: {0}", floatZahlEins * floatZahlZwei);
            Console.WriteLine("Multiplikation double: {0}", doubleZahlEins * doubleZahlZwei);
            Console.WriteLine("Addition decimal: {0}", decimalZahlEins * decimalZahlZwei);
            Console.WriteLine();

            Console.WriteLine("Division float: {0}", floatZahlEins / floatZahlZwei);
            Console.WriteLine("Divison double: {0}", doubleZahlEins / doubleZahlZwei);
            Console.WriteLine("Addition decimal: {0}", decimalZahlEins / decimalZahlZwei);

            Console.ReadLine();
        }
    }
}
