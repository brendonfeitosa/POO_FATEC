// Função Main()

using InterfaceAutenticavel;

Gerente g = new Gerente();
g.Nome = "Gerente";
g.Senha = 123;

Diretor d = new Diretor();
d.Nome = "Diretor";
d.Senha = 100;

Cliente c = new Cliente();
c.Nome = "Cliente";
c.Endereco = "Rua xxxx, x";
c.Senha = 200;

//IAutenticavel ia = new IAutenticavel(); //vai dar erro

IAutenticavel ia;

ia = g;
System.Console.WriteLine(g.Nome + " - " + ia.Autenticar(123));
//ia.Autenticar(123);

System.Console.WriteLine(d.Nome + " - " + ia.Autenticar(2));

ia = c;
System.Console.WriteLine(c.Nome + " - " + ia.Autenticar(200));