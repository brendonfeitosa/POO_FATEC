// Função main()

using ComposicaoBanco;

Console.Clear();

ContaCorrente cc1 = new ContaCorrente(10, 1000, 200);
ContaCorrente cc2 = new ContaCorrente(11, 1000, 30000);
ContaCorrente cc3 = new ContaCorrente(12, 1000, 20);

List<ContaCorrente> vetCc = new List<ContaCorrente>();

vetCc.Add(cc1);
vetCc.Add(cc2);
vetCc.Add(cc3);

Poupanca pp1 = new Poupanca(1, 500);
Poupanca pp2 = new Poupanca(2, 3000);
Poupanca pp3 = new Poupanca(3, 10000);

List<Poupanca> vetp = new List<Poupanca>();

vetp.Add(pp1);
vetp.Add(pp2);
vetp.Add(pp3);

Banco banco = new Banco(vetCc, vetp);

banco.MostrarContas();
System.Console.WriteLine("\n********************* Saque Conta Corrente *********************");
cc1.Sacar(300);
cc2.Sacar(5000);
cc3.Sacar(100);

banco.MostrarContas();
System.Console.WriteLine("\n********************* Depósito Conta Corrente *********************");
cc1.DepositarCc(20);
cc2.DepositarCc(500);
cc3.DepositarCc(100);

banco.MostrarContas();

System.Console.WriteLine("\n********************* Saque Poupança *********************");
pp1.DepositarPoupanca(50);
pp2.DepositarPoupanca(100);
pp3.DepositarPoupanca(1000);

banco.MostrarContas();

System.Console.WriteLine("\n********************* Depósito Poupança *********************");
pp1.SacarPoupanca(500);
pp2.SacarPoupanca(20);
pp3.SacarPoupanca(1000);

banco.MostrarContas();