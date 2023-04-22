using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private double preco;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"\nCódigo: {Codigo} Nome do Produto: {Nome} Preço: {Preco:C}");
        }

    }
}