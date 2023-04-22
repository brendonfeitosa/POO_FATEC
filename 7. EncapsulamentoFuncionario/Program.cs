//função Main()

using EncapsulamentoFuncionario;

Funcionario f1 = new Funcionario();
f1.Codigo = 12; //set esta sendo executado porque tenho sinal de atribuição
System.Console.WriteLine($"Código do funcionário: {f1.Codigo}"); //get sendo executado porque não tenho sinal de atribuição
