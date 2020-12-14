using System;
using System.Globalization;

namespace _ConsoleEstoque
{
    class Produto
    {
        // Atributos
        private string _nome;
        public double Preco { get; private set; }
        public int Qtd { get; private set; }

        // Construtores
        public Produto(){
        }
        public Produto(string nome, double preco, int qtd)
        {
            this._nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
        }
    }
}