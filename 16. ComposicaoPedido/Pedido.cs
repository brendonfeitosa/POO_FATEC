using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoPedido
{
    public class Pedido
    {
        public int CodigoPedido { get; set; }
        public string Data { get; set; }
        public PedidoItem _PedidoItem { get; set; }

        public Pedido(int codped, string dt, int codpeditem, int qtd)
        { //os dois ultimos parametros são da classe pedido item, são obriatórios
            CodigoPedido = codped;
            Data = dt;
            _PedidoItem = new PedidoItem(codpeditem, qtd); //aqui estabeleço a relação de composição
        }

        public Pedido(int codped, string dt, PedidoItem pi)
        {
            CodigoPedido = codped;
            Data = dt;
            _PedidoItem = pi;
        }
    }
}