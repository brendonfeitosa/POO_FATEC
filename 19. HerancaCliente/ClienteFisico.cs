using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{//            Classe derivada : Classe base
    public class ClienteFisico : Cliente
    {
        private int cpf;
        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private int rg;
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public ClienteFisico()
        {
            
        }
        //                                                preciso declarar (base) para que o programa rode, diz que depende da super classe
        public ClienteFisico(int codigo, string nome, string endereco, int cpf, int rg) : base(codigo, nome, endereco)
        {
            Cpf = cpf;
            Rg = rg;
        }
        
        public void Mostrar(){
            base.Mostrar(); //para usar o código usado na classe pai
            System.Console.WriteLine("CPF: " + Cpf + "\tRG: " + Rg);
        }
    }
}