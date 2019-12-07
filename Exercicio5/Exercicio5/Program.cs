using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Pessoa");
            Console.WriteLine("Informe a palavra que te digo qual é a primeira e ultima letra.");
            var palavra = Console.ReadLine();
            Console.WriteLine("Primeira letra");
            Console.WriteLine(palavra.First());
            Console.WriteLine("Ultima letra");
            Console.WriteLine(palavra.Last());

            Console.ReadKey(true);

        }
    }
}
