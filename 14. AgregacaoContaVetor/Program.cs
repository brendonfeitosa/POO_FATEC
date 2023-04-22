// função Main() implicita

using AgregacaoContaVetor;
Console.Clear();

Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 1000;

Cliente cliente1 = new Cliente("Lia", 1111, 111);
Cliente cliente2 = new Cliente("Bia", 22222, 222);
Cliente cliente3 = new Cliente("Paulo", 3333, 333);

c1.VetorTitular = new List<Cliente>(); //instancia do objeto List
c1.VetorTitular.Add(cliente1);
c1.VetorTitular.Add(cliente2);
c1.VetorTitular.Add(cliente3);

c1.MostrarConta();
System.Console.WriteLine("\n*********** Titular(a'es) da conta ***********");
foreach(Cliente cli in c1.VetorTitular) {
    cli.MostarCliente();
}
