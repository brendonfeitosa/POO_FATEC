// função Main()  implicita
using ArrayProduto;

// declaração do vetor
Produto[] vetorProduto = new Produto[3];
for (int i = 0; i < vetorProduto.Length; i++)
{
    vetorProduto[i] = new Produto();
    //digitação dos atributos da classe
    System.Console.Write("\nDigite o código do produto: ");
    vetorProduto[i].Codigo = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Digite o nome do produto: ");
    vetorProduto[i].Nome = Console.ReadLine();
    System.Console.Write("Digite o preço do produto: R$ ");
    vetorProduto[i].Preco = Convert.ToDouble(Console.ReadLine());
}

//apresentar o vetor
double soma = 0;
System.Console.WriteLine($"\nDados iniciais: ");
foreach (Produto vetor in vetorProduto)
{
    vetor.MostrarAtributos();
    soma = soma + vetor.Preco;
}
//calcular média de preço dos produtos
System.Console.WriteLine("\nCalcular a média!");
double media = soma / vetorProduto.Length;
System.Console.WriteLine($"\nA média de preço dos produtos é de {media:C}");

//contar quantos preços estão acima de R$ 200,00
int contador = 0;
foreach (Produto vetor in vetorProduto)
{
    if(vetor.Preco > 200)
    {
        contador += 1;
    }
}
System.Console.WriteLine($"\nDentre os {vetorProduto.Length} produtos digitados, temos {contador} com preços maiores de R$ 200,00");
if (vetorProduto.Length > 200)
{
    System.Console.WriteLine("\nProdutos com valor acima de R$ 200,00.");
}
foreach (Produto vetor in vetorProduto)
{
        if(vetor.Preco > 200)
    {
        vetor.MostrarAtributos();
    }
}
