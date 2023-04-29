// Método Main()
using HerancaCliente;
Console.Clear();

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Bia";
c.Endereco = "Rua xxxxx";
c.Mostrar();


ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Lia";
cf.Endereco = "Avenida xxxx";
cf.Cpf = 111;
cf.Rg = 11;
cf.Mostrar();

ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 3;
cj.Nome = "Ads Ltda.";
cj.Endereco = "Avenida yyyy";
cj.Cnpj = 2222;
cj.Ie = 22;
//cj.Mostrar();