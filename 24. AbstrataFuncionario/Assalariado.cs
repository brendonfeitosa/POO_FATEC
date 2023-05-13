using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Assalariado : Funcionario
    {
        public Assalariado(int cod, string nom, double sal) : base(cod, nom, sal)
        {
            
        }
        public override double CalcularSalario(int diasUteis)
        {
            return Salario = Salario / 30 * diasUteis;
        }
    }
}