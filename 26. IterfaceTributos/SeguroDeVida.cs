using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IterfaceTributos
{
    public class SeguroDeVida : ITributavel
    {
        public double Valor { get; set; }

        public double CalcularTributos(){
            return Valor = 75;
        }
    }
}