// Função Main()

using IterfaceTributos;

ContaCorrente cc = new ContaCorrente();
cc.Saldo = 1000;
System.Console.WriteLine($"\nSe a conta corrente tiver um saldo de {cc.Saldo:C}, pagará {cc.CalcularTributos():C} de imposto!");

SeguroDeVida sv = new SeguroDeVida();
System.Console.WriteLine($"A pessoa pagará {sv.CalcularTributos():C} referente ao seguro de vida!");

TotalizadorDeTributos tt = new TotalizadorDeTributos();

ITributavel it;
it = cc;
tt.Adiciona(it);
it = sv;
tt.Adiciona(it);

System.Console.WriteLine($"O valor total de tributos é {tt.Total:C}");
System.Console.WriteLine();



