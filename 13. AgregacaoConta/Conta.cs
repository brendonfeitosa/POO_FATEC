using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; } //estou agregando os itens da classe Cliente
        public double Saldo { get; set; }

        public void MostrarAtributosConta()
        {
            System.Console.WriteLine($"Número: {Numero} \tSaldo: {Saldo}");
            Titular.MostrarAtributos();
            
        }
    }
}