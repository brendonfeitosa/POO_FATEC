using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Funcionario
    {
        public int codigo;
        public string nome;
        public float salario;

        public void MostrarFuncionarios() {
            System.Console.WriteLine("Código: "+ codigo);
            System.Console.WriteLine("Descrição: "+ nome);
            System.Console.WriteLine("Preço: "+ salario);
        }

        public void CadastrarFuncionario() {

        }

        public void ExcluirFuncionario() {
            
        }
    }
}