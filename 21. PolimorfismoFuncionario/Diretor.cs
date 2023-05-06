using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Diretor : Funcionario
    {
        public Diretor(int cod, string nom, double sal) : base(cod, nom, sal)
        {}

        public override double CalcularBonificacao()
        {
            return base.CalcularBonificacao() + 1000;
        }
    }
}