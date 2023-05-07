using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Horista : Funcionario
    {
        public int QtdHorasSemana { get; set; }

        public Horista()
        {
            
        }

        public Horista(int cod, string nom, double sal, int horasSemana) : base(cod, nom, sal)
        {
            QtdHorasSemana = horasSemana;
        }

        public override double CalcularSalario()
        {
            return base.CalcularSalario() / QtdHorasSemana;
        }

        public void Mostrar(){
            base.Mostrar();
            System.Console.WriteLine($"Valor da hora paga ao funcionário horista: {CalcularSalario():C}");
        }
    }
}