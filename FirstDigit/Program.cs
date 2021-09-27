using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string st = "var_1__Int";
            char c = firstDigit(st);
            Console.WriteLine(c);
        }

        static char firstDigit(string inputString)
        {
            List<char> list = new List<char>();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] >= (char)48 && inputString[i] <= (char)57)
                {
                    list.Add(inputString[i]);
                }
            }
            return list[0];
        }
    }
}
