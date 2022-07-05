using System;
using System.Text.RegularExpressions;

namespace Regex_Nummern
{
    class Program
    {
        static void Main(string[] args)
        {
            string _number1 = "0791234567";
            string _number2 = "079 123 45 67";
            string _number3 = "079/123 45 67";
            string _number4 = "0041791234567";
            string _number5 = "0041 79 123 45 67";
            string _number6 = "+41791234567";
            string _number7 = "+41 79 123 45 67";

            Regex _regex = new Regex(@"^(0 |\+41 | 0041)[\s|\/]?7[5-9] [\s|\/]? (\d[\s |\/]?){7}");

            Match _ausgabe1 = _regex.Match(_number1);
            Match _ausgabe2 = _regex.Match(_number2);
            Match _ausgabe3 = _regex.Match(_number3);
            Match _ausgabe4 = _regex.Match(_number4);
            Match _ausgabe5 = _regex.Match(_number5);
            Match _ausgabe6 = _regex.Match(_number6);
            Match _ausgabe7 = _regex.Match(_number7);

            if (_ausgabe1.Success)
            {
                Console.WriteLine("Ihre Handynummer ist folgende: {0}", _number1);
            }
            if (_ausgabe2.Success)
            {
                Console.WriteLine("Ihre Handynummer ist folgende: {0}", _number2);
            }
            if (_ausgabe3.Success)
            {
                Console.WriteLine("Ihre Handynummer ist folgende: {0}", _number3);
            }
            if (_ausgabe4.Success)
            {
                Console.WriteLine("Ihre Handynummer ist folgende: {0}", _number4);
            }
            if (_ausgabe5.Success)
            {
                Console.WriteLine("Ihre Handynummer ist folgende: {0}", _number5);
            }
            if (_ausgabe6.Success)
            {
                Console.WriteLine("Ihre Handynummer ist folgende: {0}", _number6);
            }
            if (_ausgabe7.Success)
            {
                Console.WriteLine("Ihre Handynummer ist folgende: {0}", _number7);
            }
            else
            {
                Console.WriteLine("Ihre Handynummer ist ungültig!");
            }
            Console.ReadKey();
        }
    }
}
