using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Comissionado : Funcionario
    {
        public double Porcentagem { get; set; }
        public Comissionado(int cod, string nom, double sal, double percent) : base(cod, nom, sal)
        {
            Porcentagem = percent;
        }
        public override double CalcularSalario(int diasUteis)
        {
            return Salario += Salario / 30 * diasUteis * Porcentagem;
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($" - Porcentagem: {Porcentagem:N}%");
        }
    }
}