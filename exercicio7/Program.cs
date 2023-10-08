using System;

class exercicio7
{
    static void Main(String[] args)
    {
        int codigo;
        string produto;
        int quantidade;
        double valorUnt;
        double valorTotal;


        Console.Write("Digite o código do produto: ");
        codigo = int.Parse(Console.ReadLine());
        Console.Write("Digite o nome do produto: ");
        produto = Console.ReadLine();
        Console.Write("Digite a quantidade comprada: ");
        quantidade = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor unitário do produto: ");
        valorUnt = double.Parse(Console.ReadLine());

        Console.WriteLine($"Código do Produto: #{codigo}");
        Console.WriteLine($"Produto:{produto}");
        Console.WriteLine($"Quantidade: {quantidade} ");
        Console.WriteLine($"Valor unitário: R$ {valorUnt}");
        Console.WriteLine($"Valor Total: R$ {}");

    }
}