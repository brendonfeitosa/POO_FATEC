/*Cadastrar 3 funcionários
Calcular a média salarial
Apresentar nome e salário de quem recebe mais de 300 reais
criar um método na classe Funcionário para aplicar aumento aos salario menores que 300 reais*/

// função Main()

using ArrayFuncionario;

double soma = 0;
Funcionario[] vetorFuncionario = new Funcionario[3];
for(int i = 0; i <vetorFuncionario.Length; i++) {
    vetorFuncionario[i] = new Funcionario(); //instanciar o vetor
    //começar a digitação
    System.Console.Write("\nDigite o código: ");
    vetorFuncionario[i].codigo = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Digite o nome do funcionário: ");
    vetorFuncionario[i].nome = Console.ReadLine();
    System.Console.Write("Digite o salário: R$ ");
    vetorFuncionario[i].salario = Convert.ToDouble(Console.ReadLine());
    soma += vetorFuncionario[i].salario;
}
double media = soma / vetorFuncionario.Length;
System.Console.WriteLine($"\nA média salarial é: {media:C}\n");


System.Console.WriteLine("Os salários maiores que R$ 300,00 são dos seguintes funcionários:");
foreach(Funcionario f in vetorFuncionario) {
    if(f.salario > 300) {
        f.MostrarFuncionarios();
    }
}

foreach(Funcionario f in vetorFuncionario) {
    if(f.salario < 300) {
        Console.WriteLine($"\nO salário do funcionário abaixo é menor que R$ 300,00, sendo assim ele tera um reajuste salarial.");
        f.MostrarFuncionarios();
        Console.Write("\nInforme o percentual para reajuste do salário: ");
        double percent_reajuste = Convert.ToDouble(Console.ReadLine());
        f.ReajustarSalario(percent_reajuste);
        Console.WriteLine($"\nFuncionário com salário reajustado:");
        f.MostrarFuncionarios();
    }
}


