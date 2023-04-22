using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        public static int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public static int Contador { get; set; }
        public Funcionario(string nome, double salario) {
            Contador ++;
            Codigo ++;
            Nome = nome;
            Salario = salario;
        }

        public Funcionario() {
            Contador ++;
            Codigo ++;
        }

        static Funcionario() {
            Codigo = 100;
            Contador ++;
        }

        public void MostrarAtributos() {
            System.Console.WriteLine($"\nCódigo: {Codigo} | Nome: {Nome} | Salário: {Salario:C}\n");
        }

        public void ReajustarSalario(double percentual) {
            double salarioReajustado = Salario + (Salario * (percentual / 100));
            Salario = salarioReajustado;
        }
    }

}