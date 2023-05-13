using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> VetFuncionario { get; set; }

        public Departamento(int cod, string desc)
        {
            Codigo = cod;
            Descricao = desc;
            VetFuncionario = new List<Funcionario>(); //instanciando o vetor
        }

        public void Admitir(Funcionario f)
        { //isto é uma interpretação de uma generalização, passei o parametro f, que pode receber funcionario comissionado ou assalariado pela mesma função
            VetFuncionario.Add(f);
        }

        public void DemitirFuncionario(int cod)
        {
            for (int i = 0; i < VetFuncionario.Count; i++)
            {
                Funcionario f = VetFuncionario.ElementAt<Funcionario>(i); //ElementAt<Funcionario>(i) é para pegar o elemento daquele indice, este trecho é uma generalização, estou fazendo com que um funcionario que esta em uma posição do vetor seja armazenado em um objeto da superclasse (um funcionario)
                if (f.Codigo == cod)
                {
                    VetFuncionario.Remove(f);
                }
            }
        }
        public void ListarFuncionario()
        {
            System.Console.WriteLine($"\nLista de funcionário do departamento: {Descricao}");
            for (int i = 0; i < VetFuncionario.Count; i++)
            {
                Funcionario f = VetFuncionario.ElementAt<Funcionario>(i); //ElementAt<Funcionario>(i) é para pegar o elemento daquele indice, este trecho é uma generalização, estou fazendo com que um funcionario que esta em uma posição do vetor seja armazenado em um objeto da superclasse (um funcionario)
                f.Mostrar();
            }
        }

        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < VetFuncionario.Count; i++)
            {
                Funcionario f = VetFuncionario.ElementAt<Funcionario>(i); //ElementAt<Funcionario>(i) é para pegar o elemento daquele indice, este trecho é uma generalização, estou fazendo com que um funcionario que esta em uma posição do vetor seja armazenado em um objeto da superclasse (um funcionario)
                folha = folha + f.CalcularSalario(diasUteis);

            }
                return folha;
            }
        }
    }