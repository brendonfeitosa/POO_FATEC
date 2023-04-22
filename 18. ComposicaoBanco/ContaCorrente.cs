using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        private double chequeEspecial;
        public double LimEspecial { get; set; }
        public int NumeroContaCorrente { get; set; }
        public double Saldo { get; set; }

        public double ChequeEspecial
        {
            set
            {
                chequeEspecial = value;
            }

            get
            {
                return chequeEspecial;
            }
        }

        public ContaCorrente(int numcontacor, double cqespecial, double saldo)
        {
            ChequeEspecial = cqespecial;
            Saldo = saldo;
            NumeroContaCorrente = numcontacor;
            LimEspecial = ChequeEspecial;
        }


        public ContaCorrente()
        {

        }

        public void Sacar(double saque)
        {
            System.Console.WriteLine($"Conta {NumeroContaCorrente} \tSaque de {saque:C}");
            double zerar_saldo;
            double novo_saldocheque;
            if (saque > 0)
            {
                if (saque > Saldo)
                {
                    if (saque < Saldo + ChequeEspecial)
                    {
                        zerar_saldo = Saldo - saque;
                        ChequeEspecial = zerar_saldo + ChequeEspecial;
                        Saldo = zerar_saldo;
                    }
                }
                else
                {
                    novo_saldocheque = Saldo - saque;
                    Saldo = novo_saldocheque;
                }
            }
        }
        public void DepositarCc(double deposito)
        {
            System.Console.WriteLine($"Conta {NumeroContaCorrente} \tDeposito de {deposito:C}");
            if (deposito > 0)
            {
                if (ChequeEspecial < LimEspecial)
                {
                    if (deposito > LimEspecial + chequeEspecial)
                    {
                        double diferenca = LimEspecial - ChequeEspecial;
                        ChequeEspecial = diferenca;
                        double restoDeposito = deposito - diferenca;
                        Saldo += restoDeposito + deposito;
                    }
                    else
                    {
                        ChequeEspecial = deposito;
                        Saldo += deposito;
                    }
                }
                else
                {
                    Saldo += deposito;
                }
            }
        }

        public void GerarExtratoCc()
        {
            System.Console.WriteLine($"Número da Conta Corrente: {NumeroContaCorrente} \tSaldo da Conta: {Saldo:C} \tSaldo Cheque Especial {ChequeEspecial:C}");
        }
    }
}