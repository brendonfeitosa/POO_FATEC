using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Endereco
    {
        public string Rua { get; set; }
        public int NumCasa { get; set; }
        public string Bairro { get; set; }
        public void MostrarAtributosEndereco() {
            System.Console.WriteLine($"Rua: {Rua} \tNúmero: {NumCasa} \tBairro: {Bairro}");
        }
        public Endereco(string rua, int n, string b)
        {
            Rua = rua;
            NumCasa = n;
            Bairro = b;
        }
    }

}