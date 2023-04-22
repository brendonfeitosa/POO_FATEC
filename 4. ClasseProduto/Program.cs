//função main()

using ClasseProduto;

Console.Clear();
Produto p1 = new Produto(); //aqui acontece a instanciação, a partir daqui posso chamar de objeto
System.Console.Write("Digite o código: ");
p1.codigo = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Digite a descrição: ");
p1.descricao = (Console.ReadLine());
System.Console.Write("Digite o preço: ");
p1.preco = Convert.ToInt32(Console.ReadLine());

Produto p2 = new Produto(); //aqui acontece a instanciação, a partir daqui posso chamar de objeto
System.Console.Write("\nDigite o código: ");
p2.codigo = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Digite a descrição: ");
p2.descricao = (Console.ReadLine());
System.Console.Write("Digite o preço: ");
p2.preco = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();
p1.MostrarProdutos();
System.Console.WriteLine();
p2.MostrarProdutos();

double soma = p1.preco + p2.preco;

System.Console.WriteLine($"\nA soma dos preços é {soma:C}"); //esse C vai colocar a formatação de moeda
System.Console.WriteLine($"\nA soma dos preços é {soma:N}"); //esse N vai colocar a formatação de númerico
