using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        public int codigo;
        public string descricao;
        public double preco;

        public void MostrarProdutos() {
            System.Console.WriteLine("Código: " + codigo);
            System.Console.WriteLine("Descrição: "+descricao);
            System.Console.WriteLine("Preço: "+preco);
        }
    }
}