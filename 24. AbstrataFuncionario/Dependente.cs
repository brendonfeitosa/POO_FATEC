using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Dependente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Dependente(int cod, string nom, int idade) {
            Codigo = cod;
            Nome = nom;
            Idade = idade;            
        }

        public bool VerificarMaiorIDade(int idade){
            int maior = 2023 - idade;
            if(idade >= 18){
                return true;
            }
            else {
                return false;
            }
        }

        public void MostrarDependente(){
            System.Console.WriteLine($"Código: {Codigo} - Nome: {Nome} - Idade: {Idade}");
        }
    }
}