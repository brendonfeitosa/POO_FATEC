//Função main() 

using CartaoCredito;
Console.Clear();

CartaodeCredito c1 = new CartaodeCredito();
System.Console.Write("\nDigite o número do cartão: ");
c1.Numero = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Digite o nome do titular do cartão: ");
c1.Nome = Console.ReadLine();
System.Console.Write("Digite o ano de vencimento: ");
while(c1.AnoVencimento <= 2022)
{
    c1.AnoVencimento = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("\nDigite o ano de vencimento: ");
}
System.Console.Write("Digite o saldo disponivel no cartão: R$ ");
c1.Saldo = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Digite o código de segurança do cartão: ");
c1.CodigoSeguranca = Convert.ToInt32(Console.ReadLine());

c1.MostrarAtributos();