using System;
using System.Globalization;

namespace ConsoleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("TV", 900.00, 10);

            Console.WriteLine("Digite o nome do produto: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine($"Dados do Produto: {p1}");
;        }
    }
}
