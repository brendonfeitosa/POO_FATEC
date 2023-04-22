using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string Data { get; set; }
        public List<ItemNf> VetItem { get; set; }

        public NotaFiscal(int num, string dt, List<ItemNf> vetorItens) {
            NumeroNf = num;
            Data = dt;
            VetItem = vetorItens;
        }

        ~NotaFiscal() { //destrutor, nunca tem parâmetro
            VetItem = null;
            System.Console.WriteLine("Destruindo a nota fiscal!");
        }
    }
}