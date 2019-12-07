using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá pessoa");
            Console.WriteLine("Digite um texto que vou informar quantos caracteres ele tem.");
            var texto = Console.ReadLine();

            Console.WriteLine(texto.Count());
            Console.ReadKey(true);
        }
    }
}
