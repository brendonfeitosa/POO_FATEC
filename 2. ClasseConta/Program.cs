// função Main() ela sempre existe, mas no .net 6 em diante não precisamos escrever

using ClasseConta; //carregar a pasta do projeto para usar a classe Conta

Conta c1; //declaração de variavel
//Conta é o tipo ou a classe e c1 é a variável

c1 = new Conta(); //instancia de objeto
//new Conta() é a instância
//new é a alocação de memória e Conta() é o contrutor que prepara as variável colocando valores inicializados
//após a inicialização da instância c1 deixa de ser chamada de variável e passa a ser um objeto
c1.MostrarAtributos();
c1.Depositar(600);
c1.MostrarAtributos();

Conta c2 = new Conta();
c2.numero = 2;
c2.titular = "Helena";
c2.saldo = 100;
c2.MostrarAtributos();

c2.Aplicacao(0.6);
c2.MostrarAtributos();

//c1.Tranferir(100,c2); vou passar os parametros para serem executados na classe conta
//if(c1.Tranferir(100,c2) == true) é redundante, porque se eu deixar como esta abaixo vai dar no mesmo
if(c1.Tranferir(1000,c2)) {
    Console.WriteLine("Transferência realizada com sucesso!");
    c1.MostrarAtributos();
    c2.MostrarAtributos();
}
else {
    Console.WriteLine("Transferência não realizada!");
}
