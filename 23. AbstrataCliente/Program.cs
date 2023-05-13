// Função Main()

using AbstrataCliente;

Console.Clear();

//Cliente c = new Cliente(1, "Ana"); confirmando que não é possivel instanciar um objeto da classe abstrata

ClienteFisico cf = new ClienteFisico(2, "Paulo", 12345678);
cf.Mostrar();