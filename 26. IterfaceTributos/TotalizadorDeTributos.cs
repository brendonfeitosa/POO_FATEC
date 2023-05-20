using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IterfaceTributos
{
    public class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Adiciona(ITributavel interfaceTributavel){
            Total += interfaceTributavel.CalcularTributos();
        }
    }
}