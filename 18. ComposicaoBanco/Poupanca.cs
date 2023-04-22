using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        public int NumeroPoupanca { get; set; }
        private double saldoPoupanca;

        public double SaldoPoupanca
        {
            set
            {
                saldoPoupanca = value;
            }
            get
            {
                return saldoPoupanca;
            }
        }
        public void DepositarPoupanca(double deposito)
        {
            System.Console.WriteLine($"Conta {NumeroPoupanca} \tDeposito de {deposito:C}");
            if (deposito > 0)
            {
                SaldoPoupanca += deposito;
            }
        }

        public void SacarPoupanca(double saque)
        {
            System.Console.WriteLine($"Conta {NumeroPoupanca} \tSaque de {saque:C}");
            double zerar_saldo;
            if (saque > SaldoPoupanca)
            {
                if (saque < SaldoPoupanca)
                {
                    zerar_saldo = SaldoPoupanca - saque;
                    SaldoPoupanca = zerar_saldo;
                }
            }
            else
            {
                System.Console.WriteLine("O valor solicitado é maior do que o saldo disponível na poupança!");
            }
        }

        public Poupanca(int numpoupanca, double saldop)
        {
            NumeroPoupanca = numpoupanca;
            SaldoPoupanca = saldop;
        }

        public void MostrarRendimentoPoupanca()
        {
            System.Console.WriteLine($"Número da Poupança: {NumeroPoupanca} \tSaldo Conta Poupança: {SaldoPoupanca:C}");
        }
    }
}