using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        public string DtValidade { get; set; }
        public string DtFabricacao { get; set; }
        public int Lote { get; set; }

        public Perecivel()
        {
            
        }

        public Perecivel(int cod, string nom, double preco, string dtVal, string dtFab, int lote) : base(cod, nom, preco)
        {
            DtValidade = dtVal;
            DtFabricacao = dtFab;
            Lote = lote;
        }

        public void Mostrar() {
            base.Mostrar();
            Console.WriteLine($"Data de Válidade: {DtValidade} \tData de Fabricação: {DtFabricacao} \tLote {Lote}");
        }
    }
}