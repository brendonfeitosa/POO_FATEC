using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Mensalista : Funcionario
    {
        public int QtdHorasTrabalhadas { get; set; }

        public Mensalista()
        {

        }

        public Mensalista(int cod, string nom, double sal, int horas) : base(cod, nom, sal)
        {
            QtdHorasTrabalhadas = horas;
        }

        public override double CalcularSalario()
        {
            //220 são a quantidade de horas trabalhadas por mês
            return base.CalcularSalario() / 220;
        }


        public void Mostrar(){
            base.Mostrar();
            System.Console.WriteLine($"Valor da hora paga ao funcionário mensalista: {CalcularSalario():C}");
            //System.Console.WriteLine("\n----------------------------------------------------\n");
        }
    }
}