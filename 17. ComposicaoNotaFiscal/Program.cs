// Função Main()
using ComposicaoNotaFiscal;

ItemNf it1 = new ItemNf(10);
ItemNf it2 = new ItemNf(15);

List<ItemNf> vetoritens = new List<ItemNf>();
vetoritens.Add(it1);
vetoritens.Add(it2);

NotaFiscal nf = new NotaFiscal(1, "24/03/2023", vetoritens);

foreach(ItemNf item in nf.VetItem)
{
    Console.WriteLine("Quantidade: "+ item.Quantidade);
}
 nf = null;
 GC.Collect();