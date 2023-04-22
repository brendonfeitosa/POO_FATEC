// função Main()
using ConstrutorConta;
Console.Clear();
Conta c1 = new Conta();
c1.Mostrar();

Conta c2 = new Conta(1);
c2.Mostrar();

Conta c3 = new Conta(2, "Bob", 100);
c3.Mostrar();

System.Console.WriteLine("Qtd de instências? "+Conta.Contador +"\n");
//Quantas instancias foram realizadas?
//Implemente esta lógica;

//ClasseEstatica c = new ClasseEstatica();
//System.Console.WriteLine("\nClasse Estatica");
ClasseEstatica.MostrarFrase(); //exemplo de chamada de método de uma classe estática
