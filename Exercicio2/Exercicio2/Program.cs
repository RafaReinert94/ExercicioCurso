using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá pessoa");
            Console.WriteLine("Quem é você?");

            var nome = Console.ReadLine();

            Console.WriteLine($"Bem vindo {nome}");

            Console.ReadKey(true);
        }
    }
}
