using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayFuncionario
{
    public class Funcionario
    {
        public int codigo;
        public string nome;
        public double salario;
        public void MostrarFuncionarios() {
        System.Console.WriteLine($"Código: {codigo} \t Nome: {nome} \t {salario:C}");
        }

        public void ReajustarSalario(double percentual){
            salario += (salario * (percentual / 100));
        }
    }


}