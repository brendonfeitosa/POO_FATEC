using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public List<Dependente> Depend { get; set; }
        public double Salario { get; set; }
        public abstract double CalcularSalario(int diasUteis);
        public virtual void Mostrar() {
            Console.Write($"\nCódigo: {Codigo} - Nome: {Nome} - Salario: {Salario:C}");
        }
        public Funcionario(int cod, string nom, double sal)
        {
            Codigo = cod;
            Nome = nom;
            Salario = sal;
        }
        
    }
}