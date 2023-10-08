using System;

class desafio7
{
    static void Main()
    {
        Console.WriteLine("Iniciando sistemas de vendas...");
        Console.WriteLine("________________________________");
        Console.Write("Digite o código do produto: ");
        int codigoProduto = int.Parse(Console.ReadLine());
        Console.Write("Digite o nome do produto: ");
        string nomeProduto = Console.ReadLine();
        Console.Write("Digite a quantidade comprada: ");
        int quantidadeComprada = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor unitário do produto: R$");
        double valorUnitario = double.Parse(Console.ReadLine());

        Console.WriteLine("Carregando dados da venda...");
        Console.Clear();

        Console.WriteLine("________________________________");
        Console.WriteLine($"Id: #{codigoProduto}");
        Console.WriteLine($"Nome do produto: {nomeProduto}");
        Console.WriteLine($"Quantidade comprada: {quantidadeComprada} Und");
        Console.WriteLine($"Valor unitário: R${valorUnitario}");
        Console.WriteLine($"Valor total da venda: R${quantidadeComprada * valorUnitario}");
        Console.WriteLine("________________________________");
        Console.WriteLine("Venda Efetuada com sucesso!");
    }
}