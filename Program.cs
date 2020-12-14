using System;
using System.Globalization;

namespace ConsoleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;
            int opcao;
            Produto p1 = new Produto("TV", 900.00, 10);

            Console.Clear();
            Console.Write("Digite o nome do produto: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Digite o preço inicial do produto: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Dados do Produto: {p1}");
            
            do
            {
                Console.WriteLine("Escolha uma Operação\n1 - Adicionar Produto\n2- - Remover Produtos\n3 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        Console.Write("\nGostaria de adicionar quantas quantidade do produto: ");
                        p1.AddProduto(int.Parse(Console.ReadLine()));
                        Console.WriteLine($"Dados Atualizados: {p1}");
                        break;
                    case 2:
                        Console.Write("\nGostaria de remover quantos produtos: ");
                        p1.DelProduto(int.Parse(Console.ReadLine()));
                        Console.WriteLine($"Dados Atualizados: {p1}");
                        break;
                    case 3:
                        resp = "Sim";
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }

                Console.Write("Você deseja fazer outra operação (Sim/Não): ");
                resp = Console.ReadLine();
            } while (resp == "Sim" || resp == "SIM" || resp == "sim" || resp == "s" || resp == "S");
            
;        }
    }
}
