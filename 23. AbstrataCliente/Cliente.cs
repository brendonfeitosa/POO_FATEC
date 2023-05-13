using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public abstract class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Cliente(int cod, string nom)
        {
            Codigo = cod;
            Nome = nom;
        }
    }
}