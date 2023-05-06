using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Gerente : Funcionario
    {
        public Gerente(int cod, string nom, double sal) : base(cod, nom, sal)
        {}
        public override double CalcularBonificacao()
        {
            return Salario * 15 / 100;
        }
    }
}