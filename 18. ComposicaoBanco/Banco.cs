using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        public List<ContaCorrente> ContaC { get; set; }
        public List<Poupanca> Poup { get; set; }

        public Banco(List<ContaCorrente> cc, List<Poupanca> pp)
        {
            ContaC = cc;
            Poup = pp;
        }

        public Banco() {

        }

        public void MostrarContas() {
            System.Console.WriteLine("---------------------------------- Dados do Banco ----------------------------------");
            System.Console.WriteLine("\n****************** Contas Corrente ******************");
            foreach (ContaCorrente vetCc in ContaC)
            {
                vetCc.GerarExtratoCc();
            }
            System.Console.WriteLine("\n****************** Contas Poupança ******************");
            foreach (Poupanca vetpoup in Poup)
            {
                vetpoup.MostrarRendimentoPoupanca();
            }
        }
    }
}