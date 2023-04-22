// função Main() implicita

using ArrayConta;

//declaração de vetor

Conta[] vetorConta = new Conta[3];

for(int i = 0; i < vetorConta.Length; i++) {
    vetorConta[i] = new Conta(); //instanciando o objeto
    Console.Write("Digite o número da conta: ");
    vetorConta[i].numero = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Digite o titular: ");
    vetorConta[i].titular = Console.ReadLine();
    System.Console.Write("Digite o Saldo: ");
    vetorConta[i].saldo = Convert.ToDouble(Console.ReadLine());
}

foreach(Conta c in vetorConta) {
    c.MostrarAtributos();
}

for(int i = 0; i < vetorConta.Length; i++) {
    vetorConta[i].MostrarAtributos();
}
