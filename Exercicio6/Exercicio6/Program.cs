using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Pessoa");
            Console.WriteLine("Escreva a palavra banana e eu troco por laranja");
            var palavra = Console.ReadLine();


            if (palavra == "banana")
            {
                palavra = "laranja";
                Console.WriteLine($"Agora a palavra se tornou {palavra}.");
            }
            else
            {
                Console.WriteLine("Eu só troco banana por laranja sai fora");
            }
            Console.ReadKey(true);

        }
    }
}
