using ClasseFuncionario;
Console.Clear();
Funcionario f1 = new Funcionario();
f1.MostrarFuncionarios();

Funcionario f2 = new Funcionario();
f2.codigo = 2;
f2.nome = "Pedro";
f2.salario = 200;

f2.MostrarFuncionarios();
