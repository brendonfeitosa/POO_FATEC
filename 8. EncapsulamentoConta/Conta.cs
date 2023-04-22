using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        private int numero;
        private decimal saldo;
        private string titular;
        public int Numero
        {
            get { return numero; } //body expression get => numero; (faz a mesma coisa)
            set { 
                if(value > 0) {
                    numero = value; 
                }
                else {
                        System.Console.WriteLine("Código Inválido!"); 
                    }
                }
        }
        
        public string Titular
        {
            get { return titular.ToUpper();} //deixar maiusculo
            set { 
                if(value != "") {
                    titular = value; } 
                else
                    System.Console.WriteLine("Nome Inválido!"); titular = value; 
                    }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { 
                if(value >= 0) {
                    saldo = value; }
                else {
                    System.Console.WriteLine("Saldo Insuficiente!");
                }
                }
        }
        
        
    }
}