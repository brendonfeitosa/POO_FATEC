using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }
        public Endereco CadEndereco { get; set; }
        public Cliente(string nome, int cpf, int rg)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
        }
        public Cliente()
        {

        }
        public void MostrarAtributos() {
            System.Console.WriteLine($"Nome: {Nome} \tCPF: {Cpf} \tRG: {Rg}");
            CadEndereco.MostrarAtributosEndereco();
        }
    }
}