using System;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string _email1 = "hans.mueller@gmx.ch";
            string _email2 = "hans.mueller123@gmx.ch";
            string _email3 = "gretli.keller@vtg.admin.ch";
            string _email4 = "andreasrolli@outlook.com";
            string _email5 = "xxx_da_real_n0scoper@hotmail.com";
            string _email6 = "i.am.a.gmail.address@gmail.com";

            Regex _regex = new Regex(@"^([\w]+)[\W]?([\w]+[\W]?)*([a-z]+)?[\W]?([a-z]+)?[\.]?([\w]+)?([\w]*)@([a-z]+)(\.[a-z]+)?[\.]([a-z]+)");
                       //_result.Groups    1            2            3             4             5       6      7         8            9
                      
            Match _result = _regex.Match(_email1);
            Match _result2 = _regex.Match(_email2);
            Match _result3 = _regex.Match(_email3);
            Match _result4 = _regex.Match(_email4);
            Match _result5 = _regex.Match(_email5);
            Match _result6 = _regex.Match(_email6);

            if (_result.Success)
            {
                Console.WriteLine("It matched, email is: {0}", _email1);
                Console.WriteLine("Your name is: {0} {1}", _result.Groups[1], _result.Groups[2]);
            }
            if (_result2.Success)
            {
                Console.WriteLine("It matched, email is: {0}", _email2);
                Console.WriteLine("Your name is: {0} {1}", _result2.Groups[1], _result2.Groups[2]);
            }
            if (_result3.Success)
            {
                Console.WriteLine("It matched, email is: {0}", _email3);
                Console.WriteLine("Your name is: {0} {1}", _result3.Groups[1], _result3.Groups[2]);
            }
            if (_result4.Success)
            {
                Console.WriteLine("It matched, email is: {0}", _email4);
                Console.WriteLine("Your name is: {0}", _result4.Groups[1]);
            }
            if (_result5.Success)
            {
                Console.WriteLine("It matched, email is: {0}", _email5);
                Console.WriteLine("Your name is: {0} {1}", _result5.Groups[1], _result5.Groups[2]);
            }
            if (_result6.Success)
            {
                Console.WriteLine("It matched, email is: {0}", _email6);
                Console.WriteLine("Your name is: {0} {1}", _result6.Groups[1], _result6.Groups[2]);
            }
            else
            {
                Console.WriteLine("Not every Email matched!");
            }
            Console.ReadKey();
        }
    }
}
