using System;
using System.Globalization;

namespace ConsoleEstoque
{
    class Produto
    {
        // Atributos
        private string _nome;
        // Propriedade Autoimplementadas
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
        // Propriedade Customizada
        public string Nome {
            get { return _nome; }
            set {
                if(value != null && value.Length > 1)
                    _nome = value;
            }
        }
        // Metodos
        public double TotalEstoque()
        {
            return Preco * Qtd;
        }
        public void AddProduto(int a)
        {
            Qtd += a;
        }
        public void DelProduto(int a)
        {
            Qtd -= a;
        }
        // Override
        public override string ToString()
        {
            return Nome + " , Preço R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + " , " + Qtd.ToString("F2", CultureInfo.InvariantCulture)
                + " Unidades em Estoque, valor Total: R$ " 
                + TotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}