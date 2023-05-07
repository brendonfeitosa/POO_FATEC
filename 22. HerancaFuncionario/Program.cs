// Função Main()

using HerancaFuncionario;

Console.Clear();

Funcionario f = new Funcionario();
System.Console.WriteLine("\n-----------------------------CLASSE FUNCIONÁRIO------------------------------\n");
f.Codigo = 1;
f.Nome = "João";
f.Salario = 1000;
f.Mostrar();
System.Console.WriteLine("\n------------------------------------------------------------------------------");

Mensalista m = new Mensalista();
System.Console.WriteLine("\n-----------------------------CLASSE MENSALISTA------------------------------\n");
m.Codigo = 2;
m.Nome = "Ana";
m.Salario = 2000;
m.Mostrar();
System.Console.WriteLine("\n------------------------------------------------------------------------------");

Horista h = new Horista(3, "Maria", 3000, 20);
System.Console.WriteLine("\n-----------------------------CLASSE HORISTA------------------------------\n");
h.Mostrar();
System.Console.WriteLine("\n------------------------------------------------------------------------------");