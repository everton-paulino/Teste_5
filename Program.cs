using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Teste5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma Palavra:");
            string Palavra = Convert.ToString(Console.ReadLine());

            string Reverse = ReverseString(Palavra);

            Console.WriteLine("Palavra Original " + Palavra + Environment.NewLine);
            Console.WriteLine("Palavra Invertida " + Reverse);

            Console.ReadLine();
        }

        private static string ReverseString (string Palavra)
        {
            string Reverse = "";

            for (int count = Palavra.Length - 1; count >= 0; count--)
            {
                Reverse += Palavra[count];
            }
            return Reverse;
        }
    }
}
