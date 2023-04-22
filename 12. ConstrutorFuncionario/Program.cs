// Função Main()
using ConstrutorFuncionario;

Console.Clear();

Funcionario c1 = new Funcionario();
c1.Nome = "Lia";
System.Console.WriteLine("\nREAJUSTAR SALÁRIOS!");
c1.ReajustarSalario(50);
c1.MostrarAtributos();

Funcionario c2 = new Funcionario("Helena", 100);
System.Console.WriteLine("\nREAJUSTAR SALÁRIOS!");
c2.ReajustarSalario(15);
c2.MostrarAtributos();

System.Console.WriteLine($"Quantidade de estancias realizadas {Funcionario.Contador}\n");



