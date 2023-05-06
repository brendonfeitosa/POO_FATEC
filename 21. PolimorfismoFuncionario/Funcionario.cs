using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int cod, string nom, double sal){
            Codigo = cod;
            Nome = nom;
            Salario = sal;
        }

        public virtual double CalcularBonificacao() { //virtual fica sempre na superclasse
            return Salario * 10/100;
        }
    }
}