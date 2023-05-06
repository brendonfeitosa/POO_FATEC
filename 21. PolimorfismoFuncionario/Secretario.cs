using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Secretario : Funcionario
    {
        public int NumeroSecretario { get; set; }
        public Secretario(int cod, string nom, double sal, int numerosec) : base(cod, nom, sal){
            NumeroSecretario = numerosec;
        }

        /* public override double CalcularBonificacao()
        {
            return base.CalcularBonificacao();
        } */
    }
}