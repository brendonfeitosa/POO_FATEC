// Main()

using HerancaProduto;
Console.Clear();

Produto prod = new Produto();
prod.Codigo = 1;
prod.Nome = "Arroz";
prod.Preco = 25.55;
prod.Mostrar();

Perecivel p = new Perecivel();
p.Codigo = 2;
p.Nome = "Feijão";
p.Preco = 7.90;
p.DtValidade = "30/07/2023";
p.DtFabricacao = "08/11/2022";
p.Lote = 11111;
p.Mostrar();
