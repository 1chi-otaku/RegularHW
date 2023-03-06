using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularHW
{
    class Program
    {
        public static void Search(string str, Regex expression)
        {
            Console.WriteLine(expression.Replace(str, "*", str.Length, 0));
        }
        static void Main(string[] args)
        {
            Regex task_1 = new Regex(@"(a{1}\wb{1})");
            Regex task_2 = new Regex(@"\w{1}([A-Z-a-z]){2}\w{1}");
            Regex task_3 = new Regex(@"(abba|abea)");
            Regex task_4 = new Regex(@"a(b){1,}a");
            Regex task_5 = new Regex(@"(a{1}b*a{1})");
            Regex task_6 = new Regex(@"a(b)*a");
            Regex task_7 = new Regex(@"a(b){0,}a");
            Regex task_8 = new Regex(@"\b((ab)+)\b");

            Search("ahb acb aeb aeeb adcb axeb", task_1);
            Search("aba aca aea abba adca abea", task_2);
            Search("aba aca aea abba adca abea", task_3);
            Search("aa aba abba abbba abca abea", task_4);
            Search("aa aba abba abbba abca abea", task_5);
            Search("aa aba abba abbba abca abea", task_6);
            Search("aa aba abba abbba abca abea", task_7);
            Search("ab abab abab abababab abea", task_8);
        }
    }
}
