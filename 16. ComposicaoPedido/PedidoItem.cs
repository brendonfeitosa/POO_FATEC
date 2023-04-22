using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoPedido
{
    public class PedidoItem
    {
        private int codigoPedidoItem;
        private int quantidade;
        public int CodigoPedidoItem
        {
            get { return codigoPedidoItem; }
            set { codigoPedidoItem = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        
        public PedidoItem(int codpeditem, int qtd) {
            CodigoPedidoItem = codpeditem;
            Quantidade = qtd;
        }
    }
}