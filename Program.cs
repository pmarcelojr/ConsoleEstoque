using System;
using System.Globalization;

namespace ConsoleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;
            Produto p1 = new Produto("TV", 900.00, 10);

            Console.Clear();
            Console.Write("Digite o nome do produto: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Digite o preço inicial do produto: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Dados do Produto: {p1}");
            
            do
            {
                Console.Write("\nGostaria de adicionar quantas quantidade do produto: ");
                p1.AddProduto(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Dados Atualizados: {p1}");

                Console.Write("Você deseja adicionar mais quantidades (Sim/Não): ");
                resp = Console.ReadLine();
            } while (resp == "Sim" || resp == "SIM" || resp == "sim" || resp == "s" || resp == "S");
            
;        }
    }
}
