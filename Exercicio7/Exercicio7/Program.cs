using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Pessoa");
            Console.WriteLine("Escreva quantas palavras quiseres que eu conto quantas vogais tem.");
            var texto = Console.ReadLine();

        
            Console.WriteLine(texto.Count(x => (x == 'a')|| (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u')));
            Console.ReadKey(true);
        }

    }
}
