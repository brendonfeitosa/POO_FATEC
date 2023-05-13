// Função Main()

using AbstrataFuncionario;

Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bia", 1000);

Comissionado c1 = new Comissionado(3, "Lia", 1000, 0.2);
Comissionado c2 = new Comissionado(4, "Leo", 1000, 0.3);

/* a1.Mostrar();
System.Console.WriteLine($"Novo Salario: {a1.CalcularSalario(30):C}");
a2.Mostrar();
a2.CalcularSalario(30);
c1.Mostrar();
c1.CalcularSalario(25);
c1.Mostrar();
c2.Mostrar(); */

Departamento d1 = new Departamento(10, "TI");
d1.Admitir(a1);
d1.Admitir(c1);
d1.ListarFuncionario();

Departamento d2 = new Departamento(20, "ADM");
d2.Admitir(a2);
d2.Admitir(c2);
d2.ListarFuncionario();

//d2.DemitirFuncionario(2);
//d2.ListarFuncionario();

System.Console.WriteLine($"\nTotal da folha do departamento {d1.Descricao} = {d1.CalcularFolha(30):C}");
System.Console.WriteLine($"\nTotal da folha do departamento {d2.Descricao} = {d2.CalcularFolha(30):C}");