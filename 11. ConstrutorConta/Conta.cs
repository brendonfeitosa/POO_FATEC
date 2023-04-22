using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; } 
        public double Saldo { get; set; }

        public static int Contador { get; set; } //coloco static para que ele não seja inicalizado a cada nova instancia.

        public Conta() { //contruto padrão
            //Logica de programação
            //Se eu criar o contrutor padrão não preciso destas linhas de código
            Contador ++;
        }

        static Conta() {
            Contador = 23;
        }

        public Conta(int numero, string titular, double saldo) {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            Contador ++;
        }

        public Conta(int numero) {
            Numero = numero;
            Contador ++;
        }

        public void Mostrar() {
            System.Console.WriteLine($"\nDados da Conta: Número {Numero} | Titular {Titular} | Saldo {Saldo:C}\n");
            ClasseEstatica.MostrarFrase();//exemplo de chamada de método de uma classe estática
        }
    }
}