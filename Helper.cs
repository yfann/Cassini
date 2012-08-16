using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cassini
{
    public static class Helper
    {
        public static string Formate = "*************** {0}";

        public static void PrintMessage(string str)
        {
            Console.WriteLine(string.Format(Formate, str));
        }

        public static void PrintMessage(string formate, params string[] arr)
        {
            Console.WriteLine(string.Format(Formate, string.Format(formate, arr)));
        }
    }
}