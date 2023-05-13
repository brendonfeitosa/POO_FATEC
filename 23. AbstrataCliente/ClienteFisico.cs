using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteFisico : Cliente
    {
        public int Cpf { get; set; }

        public ClienteFisico(int cod, string nom, int cpf) : base(cod, nom)
        {
            Cpf = cpf;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo} - Nome: {Nome} - CPF: {Cpf}");
        }
    }
}