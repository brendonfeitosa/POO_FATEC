using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta
    {
        //declaração de atributos
        public int numero;
        public string titular;
        public double saldo;

        //declaração dos métodos/funções

        public void Aplicacao(double porcentagem) {
            saldo = saldo + (saldo * porcentagem/100);
        }
        public bool Tranferir(double valorTransferir, Conta objetoContaDestino){
            //A classe conta já representa a minha conta
            if (saldo >= valorTransferir){
                saldo = saldo - valorTransferir; //estou tirando saldo da minha conta para transferir
                objetoContaDestino.saldo += valorTransferir; //objetoContaDestino é a conta para qual vou transferir
                return true;
            }
            return false;
        }
        public void MostrarAtributos() {
            Console.WriteLine("Número: "+ numero);
            Console.WriteLine("Títular: "+ titular);
            Console.WriteLine("Saldo: "+ saldo);
        }
        public void Sacar(double valorSaque) {
            saldo = saldo - valorSaque;
        }

        public void Depositar(double valorDeposito) {
            saldo += valorDeposito;
        }
    }
}