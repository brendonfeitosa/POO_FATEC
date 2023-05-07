using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Funcionario
    {
        protected int codigo;
        protected string nome;
        protected double salario;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Funcionario(int cod, string nom, double sal){
            Codigo = cod;
            Nome = nom;
            Salario = sal;
        }

        public Funcionario()
        {
            
        }

        public virtual double CalcularSalario(){
            return Salario;
        }

        public void Mostrar(){
            //System.Console.WriteLine("\n----------------------------------------------------");
            System.Console.WriteLine($"Código: {Codigo} | Nome: {Nome} | Salário {Salario:C}");
        }
        
    }
}