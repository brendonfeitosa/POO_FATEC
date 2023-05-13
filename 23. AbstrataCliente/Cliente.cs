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

        public abstract void Mostrar(); //se o método for diz que a classe existe mais aqui não tem corpo de programação
        //isto obriga que as subclasses possam implementar o método da melhor forma para elas
    }
}