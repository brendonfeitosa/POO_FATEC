using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartaoCredito
{
    public class CartaodeCredito
    {
        private int numero;
        private string nome;
        private double saldo;
        private int codigoSeguranca;
        private int anoVencimento;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public int AnoVencimento
        {
            get { return anoVencimento; }
            set { 
                if(value > 2022) 
                {
                    anoVencimento = value; 
                }
                else 
                {
                    System.Console.WriteLine("\nData de vencimento inválida, tente novamente!");
                }
                }
        }
        public int CodigoSeguranca
        {
            get {
                return codigoSeguranca;
            }
            set {
                if(value != 0) {
                    codigoSeguranca = value;
                }
                else {
                    System.Console.WriteLine("O código de segurança não pode ser 0(zero)!");
                }
            }
        }

        public void MostrarAtributos() 
        {
            System.Console.WriteLine("\nDADOS DO CARTÃO!");
            System.Console.WriteLine($"Numero do cartão: {Numero}");
            System.Console.WriteLine($"Nome do titular: {Nome}");
            System.Console.WriteLine($"Saldo disponivel: {Saldo}");
            System.Console.WriteLine($"Código de segurança {codigoSeguranca}");
            System.Console.WriteLine($"Ano de vencimento: {anoVencimento}");
        }
        //implementar métodos de encapsulamento, compacto e completo para os atributos
        //valide o ano, deve ser acima de 2022
        //realize algumas instâncias e testes
    }
}