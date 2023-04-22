using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoContaVetor
{
    public class Conta
    {
        public int Numero { get; set; }
        public List<Cliente> VetorTitular { get; set; }
        public double Saldo { get; set; }
        public void MostrarConta() {
            System.Console.WriteLine($"Conta Número: {Numero} \tSaldo disponivel: {Saldo:C}");
        }
    }
}