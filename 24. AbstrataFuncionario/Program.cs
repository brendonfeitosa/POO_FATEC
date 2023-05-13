// Função Main()

using AbstrataFuncionario;

Console.Clear();

Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bia", 1000);

Comissionado c1 = new Comissionado(3, "Lia", 1000, 0.2);
Comissionado c2 = new Comissionado(4, "Leo", 1000, 0.3);

a1.Mostrar();
System.Console.WriteLine($"Novo Salario: {a1.CalcularSalario(30):C}");
a2.Mostrar();
a2.CalcularSalario(30);
c1.Mostrar();
c1.CalcularSalario(25);
c1.Mostrar();
c2.Mostrar();