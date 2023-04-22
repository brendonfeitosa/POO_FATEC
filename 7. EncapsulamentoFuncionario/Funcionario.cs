using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        //declaração de atributos encapsulados
        private int codigo;
        private string nome;
        //private double salario;

        //declaração dos métodos



        //declaração do método/propriedade de encapsulamento
        public int Codigo {
            set {
                this.codigo = value; //sei que é um atributo porque tem a palavra this
            }
            get {
                return this.codigo;
            }
        }

        //private string nome; o comando propfull cria esta linha, mas posso excluir, por já tenho ela no inicio
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double salario { get; set; }
        
    }
}