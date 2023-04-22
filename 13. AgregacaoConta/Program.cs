// Função Main()

using AgregacaoConta;
Console.Clear();
Endereco endereco = new Endereco("R. Luiz A. dos Santos", 75, "Jd. Everest");

Cliente clientes = new Cliente("Bia", 1111, 11);
Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 100;
c1.Titular = clientes;
c1.Titular.CadEndereco = endereco;
c1.MostrarAtributosConta();

Conta c2 = new Conta();
c2.Numero = 2;
c2.Saldo = 200;
c2.Titular = new Cliente();
c2.Titular.Nome = "Lia";
c2.Titular.Cpf = 2222;
c2.Titular.Rg = 22;
c2.Titular.CadEndereco = endereco;
c2.MostrarAtributosConta();

Cliente clientes2 = new Cliente("Léo", 33333,333);
Conta c3 = new Conta();
c3.Numero = 3;
c3.Saldo = 300;
c3.Titular = clientes2;
c3.Titular.CadEndereco = endereco;
c3.MostrarAtributosConta();
