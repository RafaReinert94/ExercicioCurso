using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola pessoa");
            Console.WriteLine("Qual é seu nome?");
            var nome = Console.ReadLine();
            Console.WriteLine("Qual é sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine($"Parabens {nome} você já está na fase adulta.");
            }
            else
            {
                Console.WriteLine($"Calma {nome} tudo ao seu tempo, logo você tera 18 anos de idade.");
            }
            Console.ReadKey(true);
        }
    }
}
